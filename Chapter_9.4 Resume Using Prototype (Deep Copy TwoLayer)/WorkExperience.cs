using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_9._4_Resume_Using_Prototype__Deep_Copy_TwoLayer_
{
    [Serializable]
    class WorkExperience
    {
        private string workDate;
        public string WorkDate 
        {
            get { return workDate; }
            set { workDate = value; }
        }
        private Company company;
        public string Company 
        {
            get 
            {
                if (company == null)
                {
                    return "null";
                }
                else 
                {
                    return company.CompanyName;
                }                
            }
            set 
            {
                if (company == null)
                {
                    company = new Company();
                    company.CompanyName = value;
                }
                else 
                {
                    company.CompanyName = value;
                }                
            }
        }
    }
}
