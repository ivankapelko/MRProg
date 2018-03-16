using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modbus.Serial;
using NModbus4.Device;


namespace MRProg.Connection
{
    public class ComConnection
    {
        public ModbusMasterController ModbusMasterController { get; set; }
        private ComPortConfiguration _comPortConfiguration;
        private SerialPort _serialport;
        private byte _portNumber;

        internal ComConnection(byte portnumber)
        {
            _portNumber = portnumber;
            if (ConnectionManager.Connection != null)
            {
                ConnectionManager.Connection._serialport.Close();
            }
            _serialport = new SerialPort(string.Format("COM{0}", _portNumber));
            UpdateConfiguration();
        }

        public void UpdateConfiguration()
        {
            _comPortConfiguration = ConnectionManager.GetComConfig(_portNumber);
            if (_comPortConfiguration == null)
            {
                _comPortConfiguration = new ComPortConfiguration();

                ConnectionManager.AddComConfiguration(_portNumber, _comPortConfiguration);

            }
            _serialport.BaudRate = (int)_comPortConfiguration.BaudRateProperty;
            _serialport.StopBits = _comPortConfiguration.StopBitsProperty;
            _serialport.Parity = _comPortConfiguration.ParityProperty;
            _serialport.DataBits = _comPortConfiguration.DataBitsProperty;
            _serialport.ReadTimeout = _comPortConfiguration.ReadTimeOut;
            _serialport.WriteTimeout = _comPortConfiguration.WriteTimeOut;
        }

        public bool TryOpenConnection()
        {
            try
            {

                if (!_serialport.IsOpen)
                {
                    _serialport.Open();
                    ModbusMasterController = new ModbusMasterController()
                    {
                        ModbusMaster = ModbusSerialMaster.CreateRtu(new SerialPortAdapter(_serialport))
                    };
                    ModbusMasterController.Progress = ConnectionManager.Progress; ;
                };
                
               return true;

        }
            catch (Exception e)
            {
                MessageErrorBox me = new MessageErrorBox(e.Message, "Ошибка при открытии порта");
        me.ShowErrorMessageForm();
                return false;
            }
}
    }
}
