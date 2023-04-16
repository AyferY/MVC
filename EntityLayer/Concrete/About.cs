using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class About
    {

        [Key] //key olarak belirlenen bu.
        public int AboutID { get; set; }

        [StringLength(1000)]  //aboutdetails1'in max uzunluğu 500 olsun demiş oluyorsun. Hangi property üzerine eklersen onu gösterirsin.
        public string AboutDetails1 { get; set; }
        [StringLength(1000)]
        public string AboutDetails2 { get; set; }
        [StringLength(100)]
        public string AboutImage1 { get; set; }
        [StringLength(100)]
        public string AboutImage2 { get; set; }


    }
}
