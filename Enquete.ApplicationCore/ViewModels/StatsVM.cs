using System;
using System.Collections.Generic;
using System.Text;

namespace Enquete.ApplicationCore.ViewModels
{
    public class StatsVM
    {
        public int Views { get; set; }
        public List<OptionStatsVM> votes { get; set; }
    }
}
