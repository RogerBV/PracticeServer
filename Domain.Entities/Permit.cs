using System;
using System.Collections.Generic;
using System.Text;
using Domain.Entities.Common;
using System.ComponentModel.DataAnnotations.Schema;
namespace Domain.Entities
{
    [Table("Permit")]
    public class Permit:BaseEntity
    {
        public string EmployeeName { get; set; }
        public string EmployeeSurname { get; set; }
        public int PermitTypeId { get; set; }
        [ForeignKey("PermitTypeId")]
        public PermitType PermitType { get; set; }

        public DateTime PermitDate { get; set; }

    }
}
