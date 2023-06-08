using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using HelperSystem.Domain.Models;
using HelperSystem.Domain.Interfaces;

namespace HelperSystem.Domain.ApplicantModule.Repositories
{
    public interface IPersonalInfoRepository: IEntityRepository<HelperSystem.Domain.Models.Applicant, long>
    {
       
    }
}