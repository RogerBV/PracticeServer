using System;
using System.Collections.Generic;
using System.Text;

namespace Services.Interfaces.Requests
{
    public class CreatePermit
    {
        public string EmployeeName { get; set; }
        public string EmployeeSurname { get; set; }
        public int PermitTypeId { get; set; }
        public DateTime PermitDate { get; set; }
    }
}
