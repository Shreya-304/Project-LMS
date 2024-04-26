
using System;
using System.ComponentModel.DataAnnotations;

namespace NewLms.Models
{
    public class Employee
    {
        public int EMP_ID { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string JobRole { get; set; }

        public string ReportingManager { get; set; }

        public string Gender { get; set; }


        [Display(Name = "Date of Birth")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime? DOB { get; set; }

        [Display(Name = "Contact Number")]
        [Required(ErrorMessage = "Contact number is required")]
        public string ContactNumber { get; set; }

        [Display(Name = "Email ID")]
        [Required(ErrorMessage = "Email ID is required")]
        [EmailAddress(ErrorMessage = "Invalid email address")]
        public string EmailID { get; set; }

        public string Address { get; set; }

        [Display(Name = "Date of Joining")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime? DateOfJoining { get; set; }

        [Display(Name = "Total IT Experience")]
        public int TotalITExperience { get; set; }

        [Display(Name = "Bachelor Degree")]
        public string BachelorDegree { get; set; }

        [Display(Name = "Bachelor's Specialization")]
        public string BachelorSpecialization { get; set; }

        [Display(Name = "Masters Degree")]
        public string MastersDegree { get; set; }

        [Display(Name = "Master's Specialization")]
        public string MastersSpecialization { get; set; }

        [Display(Name = "Certification")]
        public string Certification { get; set; }
    }
}