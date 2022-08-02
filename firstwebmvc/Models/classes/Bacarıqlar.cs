using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace firstwebmvc.Models.classes
{
    public class Bacarıqlar
    {
        [Key]
        public int Id { get; set; }
        public string aciqlama { get; set; }
        public byte deyer { get; set; }
    }
}