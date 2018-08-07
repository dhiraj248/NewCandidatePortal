using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace NewCandidatePortal.Models
{
    public class EmploymentData
    {
        [Key]
        public int EmploymentDataId { get; set; }
        [Required(ErrorMessage ="First Name is Required")]
        [Display(Name = "First Name")]
        [MaxLength(40)]        
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Last Name is Required")]
        [Display(Name ="Last Name")]
        [MaxLength(40)]
        public string LastName { get; set; }
        [MaxLength(40)]
        [Display(Name = "Full Middle Name")]
        public string FullMiddleName { get; set; }
        [MaxLength(40)]
        [Display(Name = "Other Name (if any)")]
        public string OtherName { get; set; }
        [Required(ErrorMessage = "Address is Required")]
        [MaxLength(80)]
        public string Address { get; set; }
        [Required(ErrorMessage = "Apartment Number is Required")]
        [Display(Name = "Apartment Number")]
        [MaxLength(10)]
        public string AptNumber { get; set; }
        [Required(ErrorMessage = "Zip Code is Required")]
        [Display(Name = "Zip Code")]
        [MaxLength(5)]
        public string ZipCode { get; set; }
        [Required(ErrorMessage = "City is Required")]
        public string City { get; set; }
        [Required(ErrorMessage = "State is Required")]
        public string State { get; set; }
        [Required(ErrorMessage = "Date of Birth is Required")]
        public DateTime DOB { get; set; }
        [Required(ErrorMessage = "Social Security Number is Required")]
        [MaxLength(11)]
        public string SSN { get; set; }
        [Required(ErrorMessage = "Primary Email is Required")]
        [Display(Name ="Primary Email")]
        [EmailAddress(ErrorMessage ="Invalid")]
        public string PrimaryEmail { get; set; }
        [Display(Name = "Secondary Email")]
        [EmailAddress(ErrorMessage ="Invalid")]
        public string SecondaryEmail { get; set; }
        [Required(ErrorMessage = "Phone is Required")]
        [Display(Name ="Primary Phone")]
        [Phone]
        public string PrimaryPhone { get; set; }        
        [Phone]
        [Display(Name = "Secondary Phone")]
        public string SecondaryPhone { get; set; }
        [Required(ErrorMessage = "First Name is Required")]
        [Display(Name = "Emergency Contact Name")]
        public string EmergencyContactName { get; set; }
        [Required(ErrorMessage = "First Name is Required")]
        [Phone]
        [Display(Name = "Emergency Contact Phone")]
        public string EmergencyContactPhone { get; set; }
        [Required(ErrorMessage = "Attestation signature is Required")]
        [Display(Name = "Attestation signature")]
        public bool IsSigned { get; set; }
        [Required(ErrorMessage = "Signature font is Required")]
        [Display(Name ="Signature font")]
        public List<string> SignatureFont { get; set; }
        
    }
}