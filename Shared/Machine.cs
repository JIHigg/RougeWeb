using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RougeWeb.Shared
{
    public class Machine
    {
        [Display(Name ="Machine ID")]
        public Guid Id { get; set; }
        [Display(Name = "Status (Online/Offline)")]
        public bool Status { get; set; }
        [Display (Name = "Machine Name")]
        public string MachineName { get; set; }

        [Display (Name = "Last Command Sent"),
         DataType(DataType.DateTime)]
        public DateTime LastCommand { get; set; }
    }
}
