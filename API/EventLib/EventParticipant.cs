using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EventLib
{
    public class EventParticipant
    {
        
        public virtual int EventId { get; set; }
        
        public virtual int DeptId { get; set; }
    }
}
