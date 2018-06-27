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
        [Required]
        [MaxLength(40)]
        public string FirstName { get; set; }
        [Required]
        [MaxLength(40)]
        public string LastName { get; set; }
        [MaxLength(40)]
        public string FullMiddleName { get; set; }
        [MaxLength(40)]
        public string OtherName { get; set; }
        [Required]
        [MaxLength(80)]
        public string Address { get; set; }
        [Required]
        [MaxLength(10)]
        public string AptNumber { get; set; }
        [Required]
        [MaxLength(5)]
        public string ZipCode { get; set; }
        [Required]
        public string City { get; set; }
        [Required]
        public string State { get; set; }
        [Required]
        public DateTime DOB { get; set; }
        [Required]
        [MaxLength(11)]
        public string SSN { get; set; }
        [Required]
        [EmailAddress]
        public string PrimaryEmail { get; set; }
        [EmailAddress]
        public string SecondaryEmail { get; set; }
        [Required]
        [Phone]
        public string PrimaryPhone { get; set; }
        [Required]
        [Phone]
        public string SecondaryPhone { get; set; }
        [Required]
        public string EmergencyContactName { get; set; }
        [Required]
        [Phone]
        public string EmergencyContactPhone { get; set; }
        [Required]
        public bool IsSigned { get; set; }
        [Required]
        public string SignatureFont { get; set; }
    }
}