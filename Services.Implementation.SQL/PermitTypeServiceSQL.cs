using System;
using System.Collections.Generic;
using System.Text;
using Services.Interfaces.Declarations;
using Services.Interfaces.Requests;
using Services.Interfaces.Responses;
using Infrastructure.SQLERepository;
using Infrastructure.DataMapping;
using System.Linq;
namespace Services.Implementation.SQL
{
    public class PermitTypeServiceSQL : IPermitTypeService
    {
        public RegisteredPermitType Create(CreatePermitType newRegistry)
        {
            throw new NotImplementedException();
        }

        public RegisteredPermitType Delete(DeletedPermitType Id)
        {
            throw new NotImplementedException();
        }

        public List<RegisteredPermitType> List()
        {
            using (PermitDataContext permitDataContext = new PermitDataContext())
            {
                return permitDataContext.PermitTypes.ToList().Select(x => x.ToDTO()).ToList();
            }
        }

        public RegisteredPermitType Update(UpdatePermitType updateRegistry)
        {
            throw new NotImplementedException();
        }
    }
}
