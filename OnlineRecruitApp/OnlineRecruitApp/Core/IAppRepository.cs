using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using OnlineRecruitApp.Models;
using OnlineRecruitApp.Core;

namespace OnlineRecruitApp.Core
{
    public interface IAppRepository : IDisposable
    {
        // Declaring interfaces
        IEnumerable<ApplicantsProfile> GetApplicants();
        ApplicantsProfile GetApplicantByID(int ApplicantID);
        void InsertApplicant(ApplicantsProfile appProfile);
        void Save();
    }
}