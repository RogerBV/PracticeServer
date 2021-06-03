using System;
using System.Collections.Generic;
using System.Text;
using Domain.Entities;
using Services.Interfaces.Requests;
using Services.Interfaces.Responses;
namespace Infrastructure.DataMapping
{
    public static class PermitDataMapping
    {
        public static Permit ToEntity(this CreatePermit newRegistry)
        {
            return new Permit()
            {
                EmployeeName = newRegistry.EmployeeName
                ,
                EmployeeSurname = newRegistry.EmployeeSurname
                ,
                PermitDate = newRegistry.PermitDate
                ,
                PermitTypeId = newRegistry.PermitTypeId
            };
        }

        public static Permit ToEntity(this UpdatePermit updatePermit)
        {
            return new Permit()
            {
                Id = updatePermit.Id
                ,EmployeeName = updatePermit.EmployeeName
                ,EmployeeSurname = updatePermit.EmployeeSurname
                ,PermitDate = updatePermit.PermitDate
                ,PermitTypeId = updatePermit.PermitTypeId
            };
        }
        
        public static RegisteredPermit ToDTO(this Permit permitOnDb)
        {
            return new RegisteredPermit()
            {
                Id = permitOnDb.Id
                ,EmployeeName = permitOnDb.EmployeeName
                ,EmployeeSurname = permitOnDb.EmployeeSurname
                ,PermitDate = permitOnDb.PermitDate
                ,PermitTypeId = permitOnDb.PermitTypeId
            };
        }
    }
}
