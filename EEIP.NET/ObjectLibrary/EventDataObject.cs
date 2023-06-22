using System;

namespace Sres.Net.EEIP.ObjectLibrary
{
    public class EventDataObject : EventArgs
    {
        public readonly byte[] T_O_IOData;

        public EventDataObject(byte[] data)
        {
            this.T_O_IOData = data;
        }
    }
}
