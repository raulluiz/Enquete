using Enquete.ApplicationCore.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Enquete.ApplicationCore.ViewModels
{
    public class PollVM
    {
        public int PollId { get; set; }
        public string Poll_description { get; set; }
    }

    public class PollOptionsVM : PollVM
    {
        public List<OptionVM> Options { get; set; }

        public PollOptionsVM(int pollId, string pollDescription, List<OptionVM> options)
        {
            this.PollId = pollId;
            this.Poll_description = pollDescription;
            this.Options = options;
        }

        //Criação para AutoMapper
        public PollOptionsVM() { }
    }

    public class PollOptionsJsonVM : PollVM
    {
        public List<string> options { get; set; }
    }
}
