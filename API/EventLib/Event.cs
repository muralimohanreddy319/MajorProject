﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace EventLib
{
    public class Events
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public virtual int EventId { get; set; }
        public virtual string EventName { get; set; }
        public virtual string EventDesc { get; set; }
        public virtual DateTime EventStartDate { get; set; }
        public virtual DateTime EventEndDate { get; set; }
        
        public virtual int Type { get; set; }
    }
}
