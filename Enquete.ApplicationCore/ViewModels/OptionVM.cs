using System;
using System.Collections.Generic;
using System.Text;

namespace Enquete.ApplicationCore.ViewModels
{
    public class OptionVM
    {
        public int OptionId { get; set; }
        public string OptionDescription { get; set; }

        public OptionVM(int optionId, string optionDescription)
        {
            this.OptionId = optionId;
            this.OptionDescription = optionDescription;
        }
        
        public OptionVM(string optionDescription)
        {
            this.OptionDescription = optionDescription;
        }
    }

    public class OptionVoteVM
    {
        public int Id { get; set; }
        public int Option_id { get; set; }
    }

    public class OptionStatsVM
    {
        public int Option_id { get; set; }
        public int Qty { get; set; }

        public OptionStatsVM(int option_id, int qty)
        {
            this.Option_id = option_id;
            this.Qty = qty;
        }
    }
}
