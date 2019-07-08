using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace UsAp2019.Models
{
    public class Ad
    {
        [ForeignKey("User")]
        public int ID { get; set; }
        public string Title { get; set; }
        public DateTime DateCreated { get; set; }
        public virtual ApplicationUser User { get; set; }
    }
}
