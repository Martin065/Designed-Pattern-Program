using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_9._4_Resume_Using_Prototype__Deep_Copy_TwoLayer_
{
    [Serializable]
    class Company
    {
        string companyName;
        public string CompanyName 
        {
            set { companyName = value; }
            get { return companyName; }
        }
    }
}
