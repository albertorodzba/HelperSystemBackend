using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


using HelperSystem.Domain.Models;
using HelperSystem.Domain.ApplicantModule.Repositories;
namespace HelperSystem.Application.UseCases
{
    public class StorePersonalInfoUseCase : IPersonalInfoRepository
    {
        private IPersonalInfoRepository _applicantRepository;
        StorePersonalInfoUseCase(IPersonalInfoRepository applicantRepository){
            _applicantRepository = applicantRepository;
        }

        public void Add(Applicant applicant)
        {
            _applicantRepository.Add(applicant);

        }

        public void Disable(long applicantID)
        {
            _applicantRepository.Disable(applicantID);

        }

        public List<Applicant> GetAll()
        {
            return _applicantRepository.GetAll();
        }

        public Applicant GetById(long applicantID)
        {
            return _applicantRepository.GetById(applicantID);
        }

        public Applicant Update(Applicant applicant)
        {
            return _applicantRepository.Update(applicant);
        }
    }
}