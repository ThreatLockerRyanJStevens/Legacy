using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreatLockerCommon.Models
{
    public class TicketHistory
    {
        public long  TicketHistoryID { get; set; }
        public long TicketID { get; set; }

        public string TicketNumber { get; set; }

        public bool IsInternal { get; set; }

        public string UpdatedBy { get; set; }

        public string NoteMethod { get; set; }

        public string NoteStatus { get; set; }
        public string NoteAssigned { get; set; }

        public string NoteManager { get; set; }

        public DateTime DateCreated { get; set; }
        public string SystemNote { get; set; }
        public string Attachments { get; set; }

        public string UserNote { get; set; }

        public string SendGridID { get; set; }


        // Can be deleted after help desk goes live.
        public string TicketNo { get; set; }
        public string NoteAssgnd { get; set; }
        public string SysNote { get; set; }
        public string UsrNote { get; set; }
    }
}
