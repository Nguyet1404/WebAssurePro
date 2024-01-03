using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebAssureProInsurance.Models.EF
{
    [Table("tb_Contact")]
    public class Contact :CommonAbstract
    {
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required(ErrorMessage = "Name Cannot Be Empty")]
        [StringLength(150,ErrorMessage = "Cannot exceed 150 characters")]
        public string Name { get; set; }
        [StringLength(150, ErrorMessage = "Cannot exceed 150 characters")]
        public string Email { get; set; }
        public string Website { get; set; }
        [StringLength(4000)]
        public string Message { get; set; }
        public bool IsRead { get; set; }
    }
}