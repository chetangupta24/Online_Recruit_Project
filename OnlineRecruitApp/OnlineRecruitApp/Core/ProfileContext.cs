using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace OnlineRecruitApp.Core
{
    public class ProfileContext : DbContext
    {
        // Creating context for communicating model objects
        public ProfileContext()
            : base("name=resumeEntities")
        { }
        public DbSet<ApplicantsProfile> Applicants { get; set; }
       
    }
}