using System;

namespace _02_Claim
{
    public enum ClaimType
    {
        Car,
        House,
        Theft
    }


    public class InsuranceContent
    {

        public int ClaimID { get; set; }
        public ClaimType Type { get; set; }
        public string Description { get; set; }
        public decimal ClaimAmount { get; set; }
        public DateTime DateOfIncident { get; set; }
        public DateTime DateOfClaim { get; set; }
        public bool IsValid { get; set; }

        public InsuranceContent() { }
        public InsuranceContent(int claimid, ClaimType type, string description, decimal claimAmount, DateTime dateOfIncident, DateTime dateOfClaim,
            bool isValid)
        {
            ClaimID = claimid;
            Type = type;
            Description = description;
            ClaimAmount = claimAmount;
            DateOfIncident = dateOfIncident;
            DateOfClaim = dateOfClaim;
            IsValid = isValid;
        }
    }
}
