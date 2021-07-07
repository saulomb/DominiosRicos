using MediatR;
using System;

namespace NerdStore.Core.Messages
{
    public abstract class Event : Message, INotification
    {
        public DateTime Timesstamp { get; private set; }

        protected Event()
        {
            Timesstamp = DateTime.Now;
        }
    }

}
