using System;
using System.Collections.Generic;
using System.Text;
using Services.Interfaces.Declarations;
using Services.Interfaces.Requests;
using Services.Interfaces.Responses;
using Infrastructure.SQLERepository;
using Infrastructure.DataMapping;
using Microsoft.EntityFrameworkCore;
using System.Linq;
namespace Services.Implementation.SQL
{
    public class PermitServiceSQL : IPermitService
    {
        public RegisteredPermit Create(CreatePermit newRegistry)
        {
            using (PermitDataContext permitDataContext = new PermitDataContext())
            {
                var ePermit = newRegistry.ToEntity();
                permitDataContext.Permits.Add(ePermit);
                permitDataContext.SaveChanges();
                return ePermit.ToDTO();
            }
        }

        public RegisteredPermit Delete(DeletedPermit Id)
        {
            throw new NotImplementedException();
        }

        public List<RegisteredPermit> List()
        {
            using (PermitDataContext permitDataContext = new PermitDataContext())
            {
                return permitDataContext.Permits.ToList().Select(x => x.ToDTO()).ToList();
            }
        }

        public RegisteredPermit Update(UpdatePermit updateRegistry)
        {
            throw new NotImplementedException();
        }
    }
}
