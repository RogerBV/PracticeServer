using System;
using System.Collections.Generic;
using System.Text;

namespace Services.Interfaces.Declarations.Common
{
    public interface ICRUDService<DTOCreate, DTOUpdate, DTORegistrered, DTODelete>
    {
        DTORegistrered Create(DTOCreate newRegistry);
        List<DTORegistrered> List();
        DTORegistrered Update(DTOUpdate updateRegistry);
        DTORegistrered Delete(DTODelete Id);
    }
}
