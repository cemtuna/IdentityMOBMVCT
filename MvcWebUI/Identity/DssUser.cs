using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcWebUI.Identity
{
    public class DssUser:IdentityUser
    {
        public int UserId { get; set; }
        public string UserFull { get; set; }
        public int UserTypeId { get; set; }
        public int FirmId { get; set; }
        public int DealerId { get; set; }
        public DateTime BirthDate { get; set; }
        public int MaritalStatus { get; set; }
        public string TcIdentity { get; set; }
 

    }
}