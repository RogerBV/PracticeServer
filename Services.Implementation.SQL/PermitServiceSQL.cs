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

        public RegisteredPermit Delete(DeletedPermit delete)
        {
            using (PermitDataContext permitDataContext = new PermitDataContext())
            {
                var objPermit = permitDataContext.Permits.Where(x => x.Id == delete.Id).ToList().First();
                permitDataContext.Permits.Remove(objPermit);
                permitDataContext.SaveChanges();
                return objPermit.ToDTO();
            }
        }

        public RegisteredPermit FindPermitById(int PermitId)
        {
            using (PermitDataContext permitDataContext = new PermitDataContext())
            {
                return permitDataContext.Permits.Where(x => x.Id == PermitId).ToList().Select(x => x.ToDTO()).ToList().First();
            }
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
            using (PermitDataContext permitDataContext = new PermitDataContext())
            {
                var permit = updateRegistry.ToEntity();
                permitDataContext.Permits.Attach(permit);
                permitDataContext.Entry(permit).Property(x => x.EmployeeName).IsModified = true;
                permitDataContext.Entry(permit).Property(x => x.EmployeeSurname).IsModified = true;
                permitDataContext.Entry(permit).Property(x => x.PermitDate).IsModified = true;
                permitDataContext.Entry(permit).Property(x => x.PermitTypeId).IsModified = true;
                permitDataContext.SaveChanges();
                return permit.ToDTO();
            }
        }
    }
}
