using System;
using System.Collections.Generic;
using System.Linq;
using OnlineRecruitApp.Models;
using System.Data;

namespace OnlineRecruitApp.Core
{
    public class AppRepository : IAppRepository
    {
        private ProfileContext _context;

        public AppRepository(ProfileContext profileContext)
        {
            this._context = profileContext;
        }
        // Defining the implementation of the interfaces in AppRepository
        public IEnumerable<ApplicantsProfile> GetApplicants()
        {
            return _context.Applicants.ToList();
        }

        public ApplicantsProfile GetApplicantByID(int ApplicantID)
        {
            return _context.Applicants.Find(ApplicantID);
        }

        public void InsertApplicant(ApplicantsProfile appProfile)
        {
            _context.Applicants.Add(appProfile);
            
         }

         public void Save()
        {
            _context.SaveChanges();
        }

        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    _context.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
    
}