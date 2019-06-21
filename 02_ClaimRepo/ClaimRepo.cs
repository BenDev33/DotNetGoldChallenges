using System;
using System.Collections;
using System.Collections.Generic;
using _02_Claim;

namespace _02_ClaimRepo
{
    public class ClaimRepo
    {
        private List<InsuranceContent> _ListOfClaim = new List<InsuranceContent>();

        public List<InsuranceContent> GetInsuranceContents()
        {
            return _ListOfClaim;
        }

        public void GetNextItems()
        {

        }
        



    }
}
