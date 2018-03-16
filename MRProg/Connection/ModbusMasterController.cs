using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NModbus4.Device;


namespace MRProg.Connection
{
   public class ModbusMasterController
    {

        public IModbusMaster ModbusMaster { get; set; }
        public IProgress<QueryReport> Progress { get; set; }
        private QueryReport _queryReport = new QueryReport();
        public async Task WriteMultipleRegistersAsync(byte deviceNum, ushort startAddress, ushort[] writeArray, string queryName)
        {
            try
            {
                Logger.AddToFile(String.Format("Запрос {0} по адресу {1} ", queryName, startAddress), writeArray.ToArray());
                await ModbusMaster.WriteMultipleRegistersAsync(deviceNum, startAddress, writeArray);
                _queryReport.IsSuccess = true;
            }
            catch (Exception e)
            {
                _queryReport.IsSuccess = false;
                Logger.AddToFile(String.Format("Запрос {0}: по адресу {1} выдал ошибку: {2}", queryName, startAddress, e.Message));
                throw;
            }
            finally
            {
                Progress?.Report(_queryReport);
            }
        }

        public async Task<ushort[]> ReadHoldingRegistersAsync(byte deviceNum, ushort startAddress, ushort numOfPoints, string queryName)
        {
            try
            {
                Logger.AddToFile(String.Format("Запрос  на чтение {0} байт  {1} по адресу {2}", numOfPoints, queryName, startAddress));
                ushort[] res = await ModbusMaster.ReadHoldingRegistersAsync(deviceNum, startAddress, numOfPoints);
                Logger.AddToFile("ОТВЕТ - ", res.ToArray());
                _queryReport.IsSuccess = true;
                return res;
            }
            catch (Exception e)
            {
                Logger.AddToFile(String.Format("Запрос  на чтение {0} байт  {1} по адресу {2}  выдал ошибку - {3}", numOfPoints, queryName, startAddress, e.Message));
                _queryReport.IsSuccess = false;
                throw;
            }
            finally
            {
                Progress?.Report(_queryReport);
            }
        }
    }
}
