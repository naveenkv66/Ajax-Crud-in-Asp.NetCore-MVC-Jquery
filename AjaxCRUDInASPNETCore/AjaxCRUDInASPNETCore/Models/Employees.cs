using System;
using System.Collections.Generic;
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
        [Column(TypeName = "nvarchar(40)")]
        public string FirstName { get; set; }
        [Column(TypeName = "nvarchar(40)")]
        public string LastName { get; set; }
        [Column(TypeName = "nvarchar(60)")]
        public string Departament { get; set; }
        public double Salary { get; set; }
        [Column(TypeName = "nvarchar(60)")]
        public string Email { get; set; }
        public DateTime Date { get; set; }
    }
}
