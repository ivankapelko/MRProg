using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NModbus4.Data;
using NModbus4.Message;
using NModBus4.Extensions;

namespace NModBus4.Message
{
    public class Function12Request : AbstractModbusMessage, IModbusRequest
    {

        private int _minimumFrameSize;



        public Function12Request(byte functionCode, ushort startAddress, byte devicenumber, byte moduletype, byte moduleNumber, ushort[] writeArray) : base(devicenumber, functionCode)
        {
            List<byte> customBytes = new List<byte>();
            customBytes.Add(devicenumber);
            customBytes.Add(functionCode);
            customBytes.Add(moduletype);
            customBytes.Add(moduleNumber);
            WriteMultipleRegistersRequest innerRequest= new WriteMultipleRegistersRequest(devicenumber,startAddress,new RegisterCollection(writeArray));
           customBytes.AddRange(innerRequest.ProtocolDataUnit);

            MessageImpl.CustomBytesInRequest = customBytes.ToArray();
        }




        #region Overrides of AbstractModbusMessage

        public override int MinimumFrameSize
        {
            get { return _minimumFrameSize; }
        }

        protected override void InitializeUnique(byte[] frame)
        {
            throw new NotImplementedException();
        }

        #endregion

        #region Implementation of IModbusRequest

        public void ValidateResponse(IModbusMessage response)
        {
            //
        }

        #endregion
    }
}
