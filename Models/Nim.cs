using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace Project.Models
{
    public class Nim
    {
        [Key]
        [Required]
        [DisplayName("PRODUCT ID")]
        public int Id { get; set; }
        [Required]
        [DisplayName("PRODUCT NAME")]
        public string Productname { get; set; }
        [Required]
        [DisplayName("CATEGORY ID")]
        public int CategoryId { get; set; }
        [Required]
        [DisplayName("CATEGORY NAME")]
        public string Categoryname { get; set; }
    }
}