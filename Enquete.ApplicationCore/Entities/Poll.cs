using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Enquete.ApplicationCore.Entities
{
    public class Poll
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PollId { get; private set; }
        public string PollDescription { get; private set; }
        public int Views { get; private set; }

        public Poll() { }
    }
}
