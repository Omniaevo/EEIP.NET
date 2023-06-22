using System;

namespace Sres.Net.EEIP.ObjectLibrary
{
    public class EventDataObject : EventArgs
    {
        public readonly byte[] T_O_IOData;
        public readonly DateTime LastReceivedImplicitMessage;

        public EventDataObject(byte[] data, DateTime date)
        {
            this.T_O_IOData = data;
            this.LastReceivedImplicitMessage = date;
        }
    }
}
