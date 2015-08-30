namespace OnlineRecruitApp
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    
    public partial class ApplicantsProfile
    {
        public int ApplicantID { get; set; }

        [Display(Name = "First Name")]
        [Required(ErrorMessage = "Name is required")]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        [Required]
        public string LastName { get; set; }

        [Display(Name = "Phone Number")]
        [Required(ErrorMessage="Phone Number Required")]
        [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$", ErrorMessage = "Entered phone format is not valid.")]
        public string PhoneNo { get; set; }

        [Display(Name = "Email ID")]
        [Required]
        [DataType(DataType.EmailAddress)]
        public string EmailID { get; set; }

        [Display(Name = "Highest Education Qualification")]
        [Required]
        public string EducationalQualification { get; set; }

        [Display(Name = "Previous Company")]
        public string PreviousCompany { get; set; }

        [Display(Name = "Experience")]
        [Required]
        [Range(0, 15)]
        public Nullable<int> YearsOfExperience { get; set; }

        [Display(Name = "Current Address")]
        public string ApplicantAddress { get; set; }

        [Display(Name = "Resume")]
        public string ApplicantResume { get; set; }

        [Display(Name = "Comments")]
        public string Comments { get; set; }
    }
}
