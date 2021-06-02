using System;
using System.Collections.Generic;
using System.Text;
using Services.Interfaces.Requests;
using Services.Interfaces.Responses;
using Services.Interfaces.Declarations.Common;
namespace Services.Interfaces.Declarations
{
    public interface IPermitService:
        ICRUDService<CreatePermit,UpdatePermit,RegisteredPermit,DeletedPermit>
    {
    }
}
