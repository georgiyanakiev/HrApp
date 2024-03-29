//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System.Web;
namespace HrApp.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class Employee
    {
        public int EmployeeID { get; set; }
        public string Name { get; set; }
        public string Position { get; set; }
        public string Office { get; set; }
        public Nullable<int> Salary { get; set; }
        [DisplayName]

        public string ImagePath { get; set; } 

        [NotMapped]
        public HttpPostedFileBase ImageUpload { get; set; }

        public Employee()
        {
            ImagePath = "~/AppFiles/Images/default.png";
        }
    }
}
