using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using MRProg.Devices;
using MRProg.Connection;
using MRProg.Module;
using MRProg.UserControls;

namespace MRProg
{
    public partial class MainForm : MetroForm
    {
        private const string GOOD_REQUESTS_PATTERN = "Успешных запросов - {0}";
        private const string BAD_REQUESTS_PATTERN = "Неудачных запросов - {0}";
        private const string ALL_REQUESTS_PATTERN = "Всех запросов - {0}";



        private IProgress<QueryReport> _queryProgress;
        private DevicesManager _deiceManager;
        private ModuleManager _moduleManager;
        private IDeviceSpecification _deviceSpecification;


        public MainForm()
        {

            InitializeComponent();
            SetVersionInformation();
            _deiceManager=new DevicesManager();
            _moduleManager=new ModuleManager();
            _queryProgress = new Progress<QueryReport>(OnQueryProgressChanged);
            ConnectionManager.Progress = _queryProgress;
        }

        private void _configurationButton_Click(object sender, EventArgs e)
        {
            comPortConfiguration.ShowConfiguration();
            _comportLable.Text = "COM"+ConnectionManager.SelectedPort;
        }

        private async void _connectButton_Click(object sender, EventArgs e)
        {
            ConnectionManager.Connection = new ComConnection(Convert.ToByte(ConnectionManager.SelectedPort));
            if (ConnectionManager.Connection.TryOpenConnection())
            {
                try
                {
                     _deviceSpecification= await _deiceManager.IdentifyDevice(Convert.ToByte(_deviceNumberTextBox.Text));
                }
                catch (Exception exception)
                {
                    MessageErrorBox message=new MessageErrorBox(exception.Message,"Не удолось подключиться к устройству");
                    message.ShowErrorMessageForm();
                    return;
                }
                if (_deviceSpecification is UnknownDeviceSpecification)
                {
                    if (_deiceManager.GetdeviceName != String.Empty)
                    {
                        MessageBox.Show(String.Format("Работа с {0} невозможна",_deiceManager.GetdeviceName));
                    }
                    else
                    {
                        MessageBox.Show("Работа с подключенным устройством невозможна");
                    }
                    
                }

                else
                {
                    if (_deviceSpecification.ControlType == ControlType.MLKTYPE)
                    {
                        SetModuleControl();
                    }
                    else
                    {
                        SetMrModuleControl();
                    }
                }
              
            }
        }


        private void SetModuleControl()
        {
            _panelControl.Controls.Clear();
            ModuleControl control=new ModuleControl();
            control.Anchor = (AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top);
            control.TypeModule = _deviceSpecification.ModuleTypes[0];
            _panelControl.Controls.Add(control);
        }

        private async void SetMrModuleControl()
        {
            _panelControl.Controls.Clear();
            int y = 0;
            try
            {
                for (int i = 0; i < _deviceSpecification.ModulesCount; i++)
                {
                    MrModuleControl control = new MrModuleControl();
                    ModuleInformation moduleInformation = await _moduleManager.ReadModuleInformation(_deviceSpecification, Convert.ToByte(_deviceNumberTextBox.Text), i);
                    control.Information = moduleInformation;
                    control.Anchor = (AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top);
                    control.TypeModule = _deviceSpecification.ModuleTypes[i];
                    control.Location = new Point(0, y);
                    control.Width = _panelControl.Width;
                    _panelControl.Controls.Add(control);
                    y = y + control.Height;
                }
            }
            catch (Exception e)
            {
                MessageErrorBox message=new MessageErrorBox(e.Message,"Не удалось прочитать информацию о модулях");
                message.ShowErrorMessageForm();
            }
          

        }

      
        private void OnQueryProgressChanged(QueryReport report)
        {
            _statisticBox.Lines = new[]
            {
                string.Format(ALL_REQUESTS_PATTERN, report.AllQueriesCount),
                string.Format(GOOD_REQUESTS_PATTERN, report.SuccessQueriesCount),
                string.Format(BAD_REQUESTS_PATTERN, report.FailedQueriesCount)
            };
        }

        public void SetVersionInformation ()
        {
            FileInfo f = new FileInfo(Application.ExecutablePath);
            _statisticBox.Text = "MRProg от " + f.LastWriteTime.ToString().Split(' ')[0];
        }

        private void _writeToDeviceButton_Click(object sender, EventArgs e)
        {
            WriteToDevice();
        }

        private void WriteToDevice()
        {

            foreach (Control control in _panelControl.Controls)
            {
                IModuleControlInerface c= control as IModuleControlInerface;
                if (c != null)
                {
                    c.WriteFile();
                }
            }
        }

    }
}
