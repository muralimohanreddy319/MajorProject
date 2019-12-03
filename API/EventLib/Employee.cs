using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace EventLib
{
    public class Employee
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public virtual int Eid { get; set; }
        public virtual string Name { get; set; }
        public virtual string EemailId { get; set; }
        public virtual int DeptId { get; set; }
        public List<Meeting> Meetings { get; set; }
        public Credential Credential { get; set; }
    }
}
