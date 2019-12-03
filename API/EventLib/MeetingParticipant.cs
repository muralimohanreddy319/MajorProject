using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace EventLib
{
    public class MeetingParticipant
    {
        public virtual int MId { get; set; }
        public virtual int EmpId { get; set; }


    }
}
