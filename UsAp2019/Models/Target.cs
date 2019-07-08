using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace UsAp2019.Models
{
    public enum Sex
    {
        Male = 0, Female = 1 // There is only 2 genders
    }
    public class Target
    {
        [Key]
        public int Id { get; set; }
        public string Country { get; set; }
        public int AgeFrom { get; set; }
        public int AgeTo { get; set; }
        public Sex Gender { get; set; }
        public virtual Ad TargetAd { get; set; }
    }
}
