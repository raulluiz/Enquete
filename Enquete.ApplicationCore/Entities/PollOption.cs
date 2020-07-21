using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Enquete.ApplicationCore.Entities
{
    public class PollOption
    {
        [Key, Column(Order = 0)]
        public int PollId { get; private set; }

        [Key, Column(Order = 1)]
        public int OptionId { get; private set; }

        public PollOption(int pollId, int optionId)
        {
            this.PollId = pollId;
            this.OptionId = optionId;
        }
    }
}
