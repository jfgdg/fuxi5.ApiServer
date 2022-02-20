using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace fuxi5.Domain
{
   public class Relationship
    {
       [Key]
        public int CId { get; set; }
        public string mante { get; set; }
        public string penage { get; set; }
    }
}
