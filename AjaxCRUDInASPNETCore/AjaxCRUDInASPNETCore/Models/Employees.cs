using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AjaxCRUDInASPNETCore.Models
{
    public class Employees
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "This Field is required")]
        [DisplayName("Fist Name")]
        [Column(TypeName = "nvarchar(40)")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "This Field is required")]
        [DisplayName("Last Name")]
        [Column(TypeName = "nvarchar(40)")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "This Field is required")]
        [Column(TypeName = "nvarchar(60)")]
        public string Departament { get; set; }

        [Required(ErrorMessage = "This Field is required")]
        public double Salary { get; set; }

        [Required(ErrorMessage = "This Field is required")]
        [Column(TypeName = "nvarchar(60)")]
        public string Email { get; set; }

        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime Date { get; set; }
    }
}
