using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Enquete.ApplicationCore.Entities
{
    public class Option
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int OptionId { get; private set; }
        public string OptionDescription { get; private set; }
        public int Qty { get; set; }

        public Option(string optionDescription)
        {
            this.OptionDescription = optionDescription;
        }

        public void Vote()
        {
            this.Qty += 1;
        }
    }
}
