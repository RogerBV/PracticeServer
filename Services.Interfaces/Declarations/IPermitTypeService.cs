using System;
using System.Collections.Generic;
using System.Text;
using Services.Interfaces.Declarations.Common;
using Services.Interfaces.Requests;
using Services.Interfaces.Responses;
namespace Services.Interfaces.Declarations
{
    public interface IPermitTypeService:
        ICRUDService<CreatePermitType,UpdatePermitType,RegisteredPermitType,DeletedPermitType>
    {
        
    }
}
