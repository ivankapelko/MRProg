using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MRProg.Connection;
using MRProg.Connection.Enum;
using MRProg.UserControls;

namespace MRProg.Module
{
    public class ModuleWritterController
    {

        #region Const
        private const string LOAD_EEPROM = "LOADEeprom";
        private const string SAVE_EEPROM = "SAVEEeprom";
        private const string LOAD_FLASH = "LOAD_FLASH";
        private const string SAVE_FLASH = "SAVE_FLASH";
        private const string LOAD_RELAY = "LOAD_RELAY";
        private const string SAVE_RELAY = "SAVE_RELAY";
        private const string PAGE_TO_WRITEBUFFER = "PAGE_TO_WRITEBUFFER  ";
        private const string PAGE_TO_READBUFFER = "PAGE_TO_RAEDBUFFER  ";
        #endregion

        private ModuleInformation _moduleInformation;
        private int _pageCount = 16;
        private ushort _startPage;
        private ushort _currentPage;
        private TypeOfMemory _typeOfMemory;
        private byte _deviceNumber;
        private ushort[] _data;
        private string _errorMessage = String.Empty;
        private Func _func;
        private bool _isMR = false;


        public ModuleWritterController(ModuleInformation moduleInformation, TypeOfMemory memoryType, byte devicenumber,ushort[] data, ushort startpage = 0, ushort count = 0)
        {
            _moduleInformation = moduleInformation;
            _typeOfMemory = memoryType;
            _deviceNumber = devicenumber;
            _data = data;
            if (moduleInformation.ControlType == ControlType.MRTYPE)
            {
                _isMR = true;
            }
            else
            {
                _isMR = false;
            }
            switch (memoryType)
            {
                case TypeOfMemory.EEPROM:
                    {
                        if ((_moduleInformation.Processor == ProcessorType.AT_MEGA_128) || (_moduleInformation.Processor == ProcessorType.AT_MEGA_2561))
                        {
                            this._pageCount = 4 * 1024 / 256;
                        }

                        if ((_moduleInformation.Processor == ProcessorType.AT_MEGA_16) || (_moduleInformation.Processor == ProcessorType.AT_MEGA_164))
                        {
                            this._pageCount = 1 * 512 / 128;
                        }


                        if ((_moduleInformation.Processor == ProcessorType.AT_MEGA_32_U4) || (_moduleInformation.Processor == ProcessorType.AT_MEGA_328_P))
                        {
                            this._pageCount = 1 * 1024 / 128;
                        }


                        break;
                    }
                case TypeOfMemory.BOOT_FLASH:
                    {

                        this._pageCount = count;
                        _startPage = startpage;
                        break;
                    }
                case TypeOfMemory.RALAY_DISCRET:
                    {
                        this._pageCount = 1;
                        this._startPage = 1020;
                        break;
                    }
                case TypeOfMemory.WORK:
                {
                    if(_moduleInformation.Processor == ProcessorType.AT_MEGA_128)
                    {
                        _pageCount = 468;
                            break;
                    }
                    else
                    {
                        _pageCount = 93;
                        break;
                        }
                }
            }
        }



        public async Task WritePageAsync(ushort[] tempArrayUshortToWrite, ushort[] writePageArray)
        {
            string name = string.Empty;
            switch (this._typeOfMemory)
            {
                case TypeOfMemory.EEPROM:
                    name = SAVE_EEPROM;
                    break;
                case TypeOfMemory.BOOT_FLASH:
                    name = SAVE_FLASH;
                    break;
                case TypeOfMemory.RALAY_DISCRET:
                    name = SAVE_RELAY;
                    break;
            }
            await ConnectionManager.Connection.ModbusMasterController?.WriteMultipleRegistersAsync(_deviceNumber, 0,
                tempArrayUshortToWrite.Take(_moduleInformation.SpiBufferSize).ToArray(), name);

            if (tempArrayUshortToWrite.Length > _moduleInformation.SpiBufferSize)
            {
                name = name + " Part2";
                await ConnectionManager.Connection.ModbusMasterController?.WriteMultipleRegistersAsync(_deviceNumber,
                    (ushort)_moduleInformation.SpiBufferSize,
                    tempArrayUshortToWrite.Skip(_moduleInformation.SpiBufferSize).ToArray(), name);
            }

            await ConnectionManager.Connection.ModbusMasterController?.WriteMultipleRegistersAsync(_deviceNumber,
                (ushort)this._moduleInformation.FlashSize, writePageArray, PAGE_TO_WRITEBUFFER + writePageArray[0]);
        }

        public async Task WritePageAsync12Function(ushort[] tempArrayUshortToWrite, ushort[] writePageArray)
        {
            string name = string.Empty;
            switch (this._typeOfMemory)
            {
                case TypeOfMemory.EEPROM:
                    name = SAVE_EEPROM;
                    break;
                case TypeOfMemory.BOOT_FLASH:
                    name = SAVE_FLASH;
                    break;
                case TypeOfMemory.RALAY_DISCRET:
                    name = SAVE_RELAY;
                    break;
            }
            await ConnectionManager.Connection.ModbusMasterController?.WriteMultipleRegistersAsyncFunction12(_deviceNumber,0,(byte)_moduleInformation.ModuleType,_moduleInformation.ModulePosition,
                tempArrayUshortToWrite.Take(_moduleInformation.SpiBufferSize).ToArray(), name);

            if (tempArrayUshortToWrite.Length > _moduleInformation.SpiBufferSize)
            {
                name = name + " Part2";
                await ConnectionManager.Connection.ModbusMasterController?.WriteMultipleRegistersAsync(_deviceNumber,
                    (ushort)_moduleInformation.SpiBufferSize,
                    tempArrayUshortToWrite.Skip(_moduleInformation.SpiBufferSize).ToArray(), name);
            }

            await ConnectionManager.Connection.ModbusMasterController?.WriteMultipleRegistersAsync(_deviceNumber,
                (ushort)this._moduleInformation.FlashSize, writePageArray, PAGE_TO_WRITEBUFFER + writePageArray[0]);
        }

        public async Task<ushort[]> LoadPageAsync(ushort[] writePageArray)
        {


            string name = string.Empty;
            switch (this._typeOfMemory)
            {
                case TypeOfMemory.EEPROM:
                    name = LOAD_EEPROM;
                    break;
                case TypeOfMemory.BOOT_FLASH:
                    name = LOAD_FLASH;
                    break;
                case TypeOfMemory.RALAY_DISCRET:
                    name = LOAD_RELAY;
                    break;
            }

            await ConnectionManager.Connection.ModbusMasterController?.WriteMultipleRegistersAsync(_deviceNumber,
                (ushort)this._moduleInformation.FlashSize, writePageArray, PAGE_TO_READBUFFER + writePageArray[0]);

            List<ushort> ushorts = new List<ushort>();

            ushorts.AddRange(await ConnectionManager.Connection.ModbusMasterController?.ReadHoldingRegistersAsync(_deviceNumber, 0, (ushort)_moduleInformation.SpiBufferSize, name));

            if (ushorts.Count < _moduleInformation.FlashSize)
            {
                name = name + " Part2";
                ushorts.AddRange(await ConnectionManager.Connection.ModbusMasterController?.ReadHoldingRegistersAsync(
                    _deviceNumber, (ushort) _moduleInformation.SpiBufferSize, (ushort) _moduleInformation.SpiBufferSize,
                    name));
                }
            return ushorts.ToArray();
        }

        public async Task StartSave( IProgress<LoadReport> progress)
        {
            if (_data.Length > this._pageCount * this._moduleInformation.FlashSize * 2)
            {
                throw new Exception("Неверный размер файла");
            }
            else
            {
                if (_data.Length % 256 == 0)
                {
                    _pageCount = (ushort)(_data.Length / 256);
                }
                else
                {
                    throw new Exception("Образ файловой системы некратен размеру страницы микроконтроллера");
                }
            }

            this._func = Func.WRITE;
            _currentPage = 0;
            await this.FillPage(progress);
        }

        private async Task FillPage(IProgress<LoadReport> progress)
        {
            ushort address = 0;
            ushort startPage = _startPage;

            for (ushort i = startPage; i < (startPage + _pageCount); i++)
            {
                bool isLoadAgain = false;
                int badQueriesCount = 0;
                do
                {

                    try
                    {

                        int arraySize = this._moduleInformation.FlashSize * 2;
                        var tempArray = new byte[arraySize];
                        Array.Copy(Common.TOBYTES(this._data,true), (i - startPage) * arraySize, tempArray, 0, arraySize);

                        var tempArrayUshortToWrite = Common.TOWORDS(tempArray, false);
                        var writePageArray = new ushort[] { i, (ushort)(Func.WRITE | (Func)this._typeOfMemory)};
                        if (_isMR)
                        {
                            await WritePageAsync12Function(tempArrayUshortToWrite, writePageArray);
                        }
                        else
                        { 
                            await WritePageAsync(tempArrayUshortToWrite, writePageArray);
                        }
                       

                        writePageArray = new ushort[] { i, (ushort)(Func.READ | (Func)this._typeOfMemory) };

                        byte[] checkingArray = Common.TOBYTES(await LoadPageAsync(writePageArray), false);

                        bool checkResult = checkingArray.SequenceEqual(tempArray);

                        progress.Report(new LoadReport() { CurrentProgressCount = i - startPage + 1, TotalProgressCount = _pageCount });
                        if (!checkResult)
                        {
                            isLoadAgain = true;
                            badQueriesCount++;
                        }
                        else
                        {
                            isLoadAgain = false;
                        }
                    }
                    catch (Exception e)
                    {
                        _errorMessage = e.Message;
                        isLoadAgain = true;
                        badQueriesCount++;
                    }
                } while (isLoadAgain && badQueriesCount < 3);


                if (badQueriesCount == 3)
                {
                    progress.Report(new LoadReport() { CurrentProgressCount = 0, TotalProgressCount = 0 });
                    throw new Exception($"Страница {i} не была записана." + Environment.NewLine + _errorMessage);

                }
                progress.Report(new LoadReport() { CurrentProgressCount = 0, TotalProgressCount = 0 });
            }
        }




    }
}
