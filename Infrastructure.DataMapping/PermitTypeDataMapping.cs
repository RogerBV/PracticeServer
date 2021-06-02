using System;
using System.Collections.Generic;
using System.Text;
using Domain.Entities;
using Services.Interfaces.Requests;
using Services.Interfaces.Responses;
namespace Infrastructure.DataMapping
{
    public static class PermitTypeDataMapping
    {
        public static RegisteredPermitType ToDTO(this PermitType permitTypeOnDb)
        {
            return new RegisteredPermitType()
            {
                Id = permitTypeOnDb.Id
                ,Description = permitTypeOnDb.Description
            };
        }
    }
}
