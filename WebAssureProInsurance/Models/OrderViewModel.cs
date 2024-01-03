using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebAssureProInsurance.Models
{
    public class OrderViewModel
    {
        [Required(ErrorMessage = "Customer name cannot be empty")]
        public string CustomerName { get; set; }
        [Required(ErrorMessage = "Phone cannot be empty")]
        public string Phone { get; set; }
        [Required(ErrorMessage = "Address cannot be empty")]
        public string Address { get; set; }
        public int TypePayment { get; set; }
    }
}