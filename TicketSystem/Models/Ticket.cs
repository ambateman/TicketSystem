using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TicketSystem.Models
{
    public class Ticket
    {
        public int TicketID { get; set; }
        public String Name { get; set; }
        public string Description { get; set; }

        [ScaffoldColumn(false)]
        public String  OpenedBy { get; set; }
        [ScaffoldColumn(false)]
        public String  ClosedBy { get; set; }
        public bool TicketOpen { get; set; }

    }
}
