using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MvcWebUI.Entities
{
    public class CEM_LU_IL
    {
        [Key]
        public int ID_IL { get; set; }
        public string DS_IL { get; set; }
        public string DS_PLAKA { get; set; }

    }
}