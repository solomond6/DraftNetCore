using System;
using System.Collections.Generic;

namespace DriverOnboarding.Models.DBModels
{
    public partial class Applications
    {
        public ulong Id { get; set; }
        public string RefNo { get; set; }
        public string Batch { get; set; }
        public string NameTitle { get; set; }
        public string Surname { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string Gender { get; set; }
        public string MaritalStatus { get; set; }
        public string Bvn { get; set; }
        public string EducationalLevel { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Religion { get; set; }
        public string StateOfOrigin { get; set; }
        public string LocalGovernmentArea { get; set; }
        public string Nationality { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string PostalAddress { get; set; }
        public string Email { get; set; }
        public string LgaofResidence { get; set; }
        public string LcdaofResidence { get; set; }
        public string Mobile { get; set; }
        public string MaidenName { get; set; }
        public string NextOfKinName { get; set; }
        public string AddressOfNextOfKin { get; set; }
        public string NextOfKinRelationship { get; set; }
        public string NextOfKinOccupation { get; set; }
        public string NextOfKinTelephoneNumber { get; set; }
        public string DriverLicenseNumber { get; set; }
        public DateTime DriverLicenseExpiryDate { get; set; }
        public decimal Score { get; set; }
        public sbyte Approved { get; set; }
        public sbyte SubmittedForApproval { get; set; }
        public sbyte Scheduled { get; set; }
        public sbyte Blacklist { get; set; }
        public string ApplicationStatus { get; set; }
        public string Remark { get; set; }
        public string RemarkReason { get; set; }
        public string FirstApprovalRejectionReason { get; set; }
        public string SecondApprovalRejectionReason { get; set; }
        public string Password { get; set; }
        public decimal UberScore { get; set; }
        public string UberId { get; set; }
        public string UberName { get; set; }
        public string ApprovedScheme { get; set; }
        public string AssignedVehicle { get; set; }
        public string AssignedVehicleRegNo { get; set; }
        public DateTime VehicleAssignmentDateTime { get; set; }
        public string AssignedVehicleDetails { get; set; }
        public string Branch { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDateTime { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime ModifiedDateTime { get; set; }
        public string Company { get; set; }
        public long RecordVersion { get; set; }
        public long Deleted { get; set; }
        public string Drn { get; set; }
    }
}
