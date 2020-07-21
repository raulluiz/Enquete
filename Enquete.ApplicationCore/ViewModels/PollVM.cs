using System;
using System.Collections.Generic;
using System.Text;

namespace Enquete.ApplicationCore.ViewModels
{
    public class PollVM
    {
        public int PollId { get; private set; }
        public string PoolDescription { get; private set; }
        public int Views { get; private set; }
    }
}
