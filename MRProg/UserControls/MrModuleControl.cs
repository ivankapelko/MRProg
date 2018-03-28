using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Controls;
using MRProg.Devices;
using MRProg.Module;

namespace MRProg.UserControls
{
    public partial class MrModuleControl : UserControl, IModuleControlInerface
    {
        #region Const

        private const string SELECT_FILE = "Выбрать файл";
        private const string READY = "Готово к записи";
        private const string ERROR_OPEN_FILE = "Ошибка открытия файла";

        private const string VERSION_ATTENTION_PATTERN =
            "Версия прошивки модуля {0} соответствует или выше версии выбранного файла";

        private const string VERSION_ERROR_PATTERN = "Программная ошибка определение версий модуля {0}";

        private const string INCORRECT_FILE = "Некорректный файл";
        #endregion

        #region Private Fields
        private string _moduleName;
        private string _moduleVersion;
        private string _fuze;
        private string _filePath;
        private byte[] _data;
        private ModuleStates _state;
        private ModuleInformation _moduleInformation;
        private ModuleType _type;
        private IProgress<LoadReport> _progressBarReport;


        #endregion

        #region Properteis
        public MrModuleControl()
        {
            InitializeComponent();
            _progressBarReport = new Progress<LoadReport>(OnProgressBarChanged);
        }
        /// <summary>
        /// Название модуля
        /// </summary>
        public string ModuleName
        {
            get { return _moduleName; }
            set
            {
                _moduleName = value;
                _moduleNameLable.Text = _moduleName;
            }
        }
        /// <summary>
        /// Версия модуля
        /// </summary>
        public string ModuleVersion
        {
            get { return _moduleVersion; }
            set
            {
                _moduleVersion = value;
                _versionLabel.Text = _moduleVersion;
                _moduleNameLable.Text = _moduleVersion;
            }
        }
        /// <summary>
        /// Фьюзы
        /// </summary>
        public string Fuze
        {
            get { return _fuze; }
            set
            {
                _fuze = value;
                _fuzeLable.Text = _fuze;
            }
        }
        /// <summary>
        /// Состояние в котором находится модуль
        /// </summary>
        public ModuleStates State
        {
            get { return _state; }
            set
            {
                this._state = value;
                try
                {

                    SetState();
                    //if (this.IsHandleCreated)
                    //{
                    //    this.Invoke(new Action(this.SetState));
                    //}
                }
                catch (Exception e)
                {

                    //Logger.Add("Ошибка переключения состояния");
                    //Logger.Add(e.Message);
                }
            }
        }

        public ModuleInformation Information
        {
            get { return _moduleInformation; }
            set
            {
                _moduleInformation = value;
                if (value != null)
                {
                    this.State = _moduleInformation.State;
                    this.Fuze = _moduleInformation.Fuze;
                    if (_moduleInformation.State == ModuleStates.LOADER)
                    {
                        this.ModuleVersion = _moduleInformation.LoaderVersion.ToString("F1");
                    }
                    else
                    {
                        this.ModuleVersion = _moduleInformation.ModuleVersion.ToString("F1");

                    }
                    this.ModuleName = ModuleManager.ModuleTypeFriendlyName(_moduleInformation.ModuleType);

                }

            }
        }

        /// <summary>
        /// Путь к файлу прошивки
        /// </summary>
        public string FilePath
        {
            get { return _filePath; }
            set { _filePath = value; }
        }
        /// <summary>
        /// Фильтр файла прошивки
        /// </summary>
        public string FileFilter
        {
            get
            {
                return String.Format(@"Файл прошивки (*.bin)|*{0}* M* R* *.*.bin", new string(this.Information.ModuleTypeString.Take(this.Information.ModuleTypeString.Length - 1).ToArray()));
                //  return String.Format("Файл прошивки (*.bin)|*{0} {1} {2}*.bin", this.ModuleTypeString, this.Modification,this.Revision);
            }
        }

        /// <summary>
        /// Регулярное выражение для имени файла
        /// </summary>
        public string FileRegexString
        {
            get { return String.Format(@"[\w\S\s]* {0} {1} {2} [\w\S\s]*\.bin", this.Information.ModuleTypeString, this.Information.Modification, this.Information.Revision); }
        }
        /// <summary>
        /// Прошивка виде слов
        /// </summary>
        public byte[] Data
        {
            get { return _data; }
            set { _data = value; }
        }
        public ModuleType TypeModule
        {
            get { return _type; }
            set
            {
                _type = value;
                ModuleName = ModuleManager.ModuleTypeFriendlyName(value);
            }
        }


        #endregion
        private bool VerefyFile()
        {
            return !((this._data.Length != 0) & ((this.Data.Length % this.Information.FlashSize) == 0));
        }
        private void OpenFile()
        {
            this._openFileDialog.FileName = string.Empty;
            _openFileDialog.Filter = FileFilter;
            if (this._openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    this.FilePath = this._openFileDialog.FileName;
                    this.SetFilePath();
                    _workProgramCheckFile.Checked = true;
                }
                catch (Exception)
                {
                    MessageBox.Show(ERROR_OPEN_FILE);
                }
            }
        }
        private void _chooseFile_Click(object sender, EventArgs e)
        {
            switch (State)
            {
                case ModuleStates.ERROR_WORK_STRING:
                    {
                        //this.SetFilePath();
                        //ErrorButtonClick();
                        return;
                    }
                case ModuleStates.ERROR_WRITEFILE_TO_MODULE:
                    {
                        /* var needStop = MessageBox.Show("Вы действительно желаете остановить запись?", "Остановка записи",
                                                   MessageBoxButtons.YesNo);
                            if (needStop == DialogResult.Yes)
                            {
                                this._bufferWritter.Stop();
                            }*/
                        return;
                    }
                case ModuleStates.CLEAR:
                    {
                        //if (this.SetDevInfo != null)
                        //{
                        //    this.SetDevInfo.Invoke(this);
                        //}
                        return;
                    }
                case ModuleStates.WITHOUTTYPE:
                    {
                        //if (this.SetDevInfo != null)
                        //{
                        //    this.SetDevInfo.Invoke(this);
                        //}
                        return;
                    }
                default:
                    {
                        this.OpenFile();
                        break;
                    }
            }
        }


        private void SetFilePath()
        {
            _data = File.ReadAllBytes(this._filePath);

            if (this.VerefyFile())
            {
                this.State = ModuleStates.CHOICEANOTHERFILE;
                Logger.Add(string.Format("Для модуля {0} выбран неккоректный файл прошивки", this.Information.ModulePosition));
                this._chooseFile.Text = INCORRECT_FILE;
                return;
            }
            try
            {
                var versionString = Path.GetFileNameWithoutExtension(this._filePath).Split()[5];
                versionString = versionString.Replace(".",
                    Thread.CurrentThread.CurrentCulture.NumberFormat.CurrencyDecimalSeparator);

                Logger.AddToFile(String.Format("Выбран файл - {0}, Размер - {1} Байт", this._filePath,
                    File.ReadAllBytes(this._filePath).Length));

                if (double.Parse(versionString) == this.Information.ModuleVersion)
                {
                    this.State = ModuleStates.WORK;
                    Logger.Add(string.Format(VERSION_ATTENTION_PATTERN, this.Information.ModulePosition));
                }

                if (double.Parse(versionString) < this.Information.ModuleVersion)
                {
                    this.State = ModuleStates.CURRENTVERSIONHIGHER;
                }

                if (double.Parse(versionString) > this.Information.ModuleVersion)
                {
                    this.State = ModuleStates.CURRENTVERSIONLESS;
                    // this.BackColor = Color.FromArgb(255, 238, 88);
                }

            }
            catch (Exception)
            {
                this.State = ModuleStates.CHOICEANOTHERFILE;
                Logger.Add(string.Format(VERSION_ERROR_PATTERN, this.Information.ModulePosition));
            }
        }

        private void SetState()
        {
            switch (_state)
            {
                case ModuleStates.WORK:
                    {
                        if (Path.GetFileName(this._filePath) != null)
                        {
                            this._workProgramCheckFile.Text = Path.GetFileName(this._filePath);
                            _workProgramCheckFile.Checked = false;
                            _workProgramCheckFile.Enabled = true;
                        }
                        else
                        {
                            this._workProgramCheckFile.Checked = false;
                            this._workProgramCheckFile.Enabled = false;
                            this._workProgramCheckFile.Text = string.Empty;
                        }
                        _progressBar.BackColor = SystemColors.Control;
                        this.groupBox1.BackColor = Color.Green;
                        this.groupBox2.BackColor = Color.Green;
                        this.groupBox3.BackColor = Color.Green;
                        this.BackColor = Color.Green;
                        this._chooseFile.Text = "Выбрать файл";
                        this._progressBar.Value = 0;
                        break;
                    }
                case ModuleStates.LOADER:
                    {
                        if (Path.GetFileName(this._filePath) != null)
                        {
                            this._workProgramCheckFile.Text = Path.GetFileName(this._filePath);
                            _workProgramCheckFile.Checked = true;
                            _workProgramCheckFile.Checked = false;
                            _workProgramCheckFile.Enabled = true;
                        }
                        else
                        {
                            this._workProgramCheckFile.Checked = false;
                            this._workProgramCheckFile.Enabled = false;
                            this._workProgramCheckFile.Text = string.Empty;
                        }
                        _progressBar.BackColor = SystemColors.Control;
                        this.groupBox1.BackColor = Color.FromArgb(165, 214, 167);
                        this.groupBox2.BackColor = Color.FromArgb(165, 214, 167);
                        this.groupBox3.BackColor = Color.FromArgb(165, 214, 167);
                        this.BackColor = Color.FromArgb(165, 214, 167);
                        this._chooseFile.Text = "Выбрать файл";
                        this._progressBar.Value = 0;
                        break;
                        break;
                    }
                case ModuleStates.ANOUTHERPOSITION:
                    {
                        if (Path.GetFileName(this._filePath) != null)
                        {
                            this._workProgramCheckFile.Text = Path.GetFileName(this._filePath);
                            _workProgramCheckFile.Checked = false;
                            _workProgramCheckFile.Enabled = true;
                        }
                        else
                        {
                            this._workProgramCheckFile.Checked = false;
                            this._workProgramCheckFile.Enabled = false;
                            this._workProgramCheckFile.Text = string.Empty;
                        }
                        this.groupBox1.BackColor = Color.Orange;
                        this.groupBox2.BackColor = Color.Orange;
                        this.groupBox3.BackColor = Color.Orange;
                        this.BackColor = Color.Orange;
                        this._chooseFile.Text = "Выбрать файл";
                        this._workProgramCheckFile.Checked = false;
                        this._workProgramCheckFile.Text = string.Empty;
                        this._progressBar.Value = 0;
                        _progressBar.BackColor = SystemColors.Control;
                        this._fuzeLable.Text = string.Empty;
                        this._versionLabel.Text = String.Empty;
                        break;
                    }
                case ModuleStates.ERROR_READ_MODULE:
                    {
                        if (Path.GetFileName(this._filePath) != null)
                        {
                            this._workProgramCheckFile.Text = Path.GetFileName(this._filePath);
                            _workProgramCheckFile.Checked = false;
                            _workProgramCheckFile.Enabled = true;
                        }
                        else
                        {
                            this._workProgramCheckFile.Checked = false;
                            this._workProgramCheckFile.Enabled = false;
                            this._workProgramCheckFile.Text = string.Empty;
                        }
                        this._moduleNameLable.Text = ModuleManager.ModuleTypeFriendlyName(Information.ModulePositionOnSpecification) + " (Отсутсвует)";
                        //this._mainButton.BackColor = SystemColors.Control;
                        this.BackColor = SystemColors.Control;
                        this._chooseFile.Text = "Нет модуля";
                        this._workProgramCheckFile.Checked = false;
                        this._workProgramCheckFile.Text = Path.GetFileName(this._filePath);
                        this._progressBar.Value = 0;
                        this.Enabled = false;
                        //this.Caption = ModuleData.ModuleTypeFriendlyName(this._moduleType);
                        this._fuzeLable.Text = string.Empty;
                        this._versionLabel.Text = String.Empty;
                        _progressBar.BackColor = SystemColors.Control;
                        break;
                    }

                case ModuleStates.CLEAR:
                    {
                        break;
                    }

                case ModuleStates.ERROR_WORK_STRING:
                    {
                        //this._mainButton.BackColor = Color.Red;
                        //this.BackColor = Color.Red;
                        //this._mainButton.Text = ERROR;
                        //this._mainCheckBox.Checked = false;
                        //this.Enabled = true;
                        break;
                    }
                case ModuleStates.ERROR_WRITEFILE_TO_MODULE:
                    {
                        _progressBar.BackColor = Color.Red;
                        break;
                    }

                case ModuleStates.WITHOUTTYPE:
                    {
                        //this._mainButton.BackColor = Color.FromArgb(255, 255, 0, 255);
                        //this.BackColor = Color.FromArgb(255, 255, 0, 255);
                        //this._mainButton.Text = "Выбор типа";
                        //this._mainCheckBox.Checked = false;
                        //this._mainCheckBox.Text = string.Empty;
                        //this._progressBar.Value = 0;
                        //_eepromProgressBar.Value = 0;
                        //_flashbootProgressBar.Value = 0;
                        //_relayProgressBar.Value = 0;
                        //this._mainCheckBox.Enabled = false;
                        //this._fuseLabel.Text = string.Empty;
                        //this.Enabled = false;
                        //this.Caption = "Неизвестен тип устройства" /* +
                        //               string.Format(BOTLOADER_VERSION_PATTERN, this._currentModule.LoaderVersion)*/;
                        //this.Enabled = true;
                        break;

                    }

                case ModuleStates.OK:
                    {
                        //this._mainButton.BackColor = Color.Green;
                        //this._mainButton.Text = WRITE_OK;
                        //this._mainCheckBox.Checked = false;
                        //this.Enabled = true;
                        break;
                    }
                case ModuleStates.CURRENTVERSIONLESS:
                    {
                        if (Path.GetFileName(this._filePath) != null)
                        {
                            this._workProgramCheckFile.Text = Path.GetFileName(this._filePath);
                            _workProgramCheckFile.Checked = false;
                            _workProgramCheckFile.Enabled = true;
                        }
                        else
                        {
                            this._workProgramCheckFile.Checked = false;
                            this._workProgramCheckFile.Enabled = false;
                            this._workProgramCheckFile.Text = string.Empty;
                        }
                        this._workProgramCheckFile.Text = Path.GetFileName(this._filePath);
                        this._progressBar.Value = 0;
                        this._chooseFile.Text = READY;
                        _workProgramCheckFile.Checked = true;
                        this._workProgramCheckFile.Enabled = true;
                        this.BackColor = Color.FromArgb(255, 238, 88);
                        this.groupBox1.BackColor = Color.FromArgb(255, 238, 88);
                        this.groupBox2.BackColor = Color.FromArgb(255, 238, 88);
                        this.groupBox3.BackColor = Color.FromArgb(255, 238, 88);
                        _progressBar.BackColor = SystemColors.Control;
                        break;
                    }

                case ModuleStates.CURRENTVERSIONHIGHER:
                    {
                        if (Path.GetFileName(this._filePath) != null)
                        {
                            this._workProgramCheckFile.Text = Path.GetFileName(this._filePath);
                            _workProgramCheckFile.Checked = false;
                            _workProgramCheckFile.Enabled = true;
                        }
                        else
                        {
                            this._workProgramCheckFile.Checked = false;
                            this._workProgramCheckFile.Enabled = false;
                            this._workProgramCheckFile.Text = string.Empty;
                        }
                        this._workProgramCheckFile.Text = Path.GetFileName(this._filePath);
                        this._progressBar.Value = 0;
                        this._chooseFile.Text = READY;
                        _workProgramCheckFile.Checked = true;
                        this._workProgramCheckFile.Enabled = true;
                        this.BackColor = Color.Pink;
                        this.groupBox1.BackColor = Color.Pink;
                        this.groupBox2.BackColor = Color.Pink;
                        this.groupBox3.BackColor = Color.Pink;
                        _progressBar.BackColor = SystemColors.Control;
                        break;
                    }
                case ModuleStates.CHOICEANOTHERFILE:
                    {
                        if (Path.GetFileName(this._filePath) != null)
                        {
                            this._workProgramCheckFile.Text = Path.GetFileName(this._filePath);
                            _workProgramCheckFile.Checked = false;
                            _workProgramCheckFile.Enabled = true;
                        }
                        else
                        {
                            this._workProgramCheckFile.Checked = false;
                            this._workProgramCheckFile.Enabled = false;
                            this._workProgramCheckFile.Text = string.Empty;
                        }
                        this._workProgramCheckFile.Text = Path.GetFileName(this._filePath);
                        _workProgramCheckFile.Enabled = false;
                        _chooseFile.Text = SELECT_FILE;
                        this.BackColor = Color.FromArgb(255, 238, 88);
                        this.groupBox1.BackColor = Color.FromArgb(255, 238, 88);
                        this.groupBox2.BackColor = Color.FromArgb(255, 238, 88);
                        this.groupBox3.BackColor = Color.FromArgb(255, 238, 88);
                        _progressBar.BackColor = SystemColors.Control;
                        _chooseFile.Enabled = true;
                        break;
                    }
            }
        }


        public async Task WriteFile()
        {
            if (this._workProgramCheckFile.Checked)
            {
                ModuleWritterController moduleWritter = new ModuleWritterController(this.Information, TypeOfMemory.WORK, DevicesManager.DeviceNumber, this._data);
                try
                {
                    await moduleWritter.StartSave(_progressBarReport);
                }
                catch (Exception e)
                {
                    this.State = ModuleStates.ERROR_WRITEFILE_TO_MODULE;
                    throw new Exception(e.Message);
                }

            }

        }

        public Action<int> NeedRefreshAction { get; set; }

        private void OnProgressBarChanged(LoadReport loadReport)
        {

            if (_progressBar.Maximum != loadReport.TotalProgressCount)
            {
                this._progressBar.Maximum = loadReport.TotalProgressCount;
            }

            this._progressBar.Value = loadReport.CurrentProgressCount;

        }

        private async void _toBootloaderButton_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Перевести в режим загрузчика?", "Внимание", MessageBoxButtons.YesNo);
            if (dr == DialogResult.No)
            {
                return;
            }
            else
            {
                try
                {
                    await ModuleWritterController.ModuleToloader(_moduleInformation.ModuleType, DevicesManager.DeviceNumber,
                        _moduleInformation.ModulePosition);

                   
                }
                catch (Exception exception)
                {
                    MessageBox.Show("Не удалось перевести в режим загрузчика");
                    NeedRefreshAction?.Invoke(_moduleInformation.ModulePosition);
                    return;
                }
                MessageBox.Show("Модуль переведен в режим загрузчика");
                NeedRefreshAction?.Invoke(_moduleInformation.ModulePosition);
            }

        }

        private async void _toWorkStateButton_Click(object sender, EventArgs e)
        {
            try
            {
                await ModuleWritterController.ModuleMLKToWork(DevicesManager.DeviceNumber,
                    _moduleInformation.FlashSize);


            }
            catch (Exception exception)
            {
                MessageBox.Show("Не удалось перевести в рабочий режим");
                NeedRefreshAction?.Invoke(_moduleInformation.ModulePosition);
                return;
            }
            MessageBox.Show("Модуль переведен в рабочий режим");
            NeedRefreshAction?.Invoke(_moduleInformation.ModulePosition);
        }
    }
}
