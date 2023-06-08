using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using HelperSystem.Domain.ApplicantModule.Repositories;
using HelperSystem.Domain.Models;

namespace HelperSystem.Infrastructure.Data.ApplicantDir.Repositories;

public class ApplicantRepository : IPersonalInfoRepository
{
    private helperSystemContext _dbContext;
    public ApplicantRepository(helperSystemContext dbContext)
    {
        this._dbContext = dbContext;
    }

    public void Add(Applicant applicant)
    {
        this._dbContext.Applicants.Add(applicant);
    }

    public void Disable(long applicantID)
    {
    }

    public List<Applicant> GetAll()
    {
        return this._dbContext.Applicants.ToList();
    }

    public Applicant GetById(long applicantID)
    {
        return this._dbContext.Applicants.Find(applicantID);
    }

    public Applicant Update(Applicant applicant)
    {
        Applicant applicantToUpdate = this._dbContext.Applicants.Find(applicant.IdApplicant);
        
        applicantToUpdate.Aboutme = applicant.Aboutme;
        applicantToUpdate.AdminObservation = applicant.AdminObservation;

        return applicantToUpdate;

    }
}
