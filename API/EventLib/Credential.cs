using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace EventLib
{
    public class Credential
    {
        [Key]
        public virtual int CredentialId { get; set; }
        public virtual int Eid { get; set; }
        public virtual string Username { get; set; }
        public virtual string Password { get; set; }
        public virtual int Rid { get; set; }
        public Employee Employee { get; set; }
        public Role Roles { get; set; }
    }
}
