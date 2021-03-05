using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using WebApplication4.Models;


namespace WebApplication4.Models
{
    public class PropertyViewModel: EditImageViewModel
    {
        [Required]
        [Display(Name = "Property Type")]
        public string PropertyType { get; set; }

        [Required]
        [Display(Name = "Property Catagory")]
        public string PropertyCatagory { get; set; }

        [Required]
        [Display(Name = "Address")]
        public string Address { get; set; }

        [Required]
        [Display(Name = "City")]
        public string City { get; set; }

        [Required]
        [Display(Name = "Location")]
        public string Location { get; set; }

        [Required]
        [Display(Name = "Status")]
        public string Status { get; set; }

        [Required]
        [Display(Name = "Price")]
        public int Price { get; set; }

        [Required]
        [Display(Name = "Size")]
        public int Size { get; set; }

    }
}