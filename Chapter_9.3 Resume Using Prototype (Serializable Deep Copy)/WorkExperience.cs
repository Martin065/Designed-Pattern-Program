using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_9._3_Resume_Using_Prototype__Serializable_Deep_Copy_
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
        private string company;
        public string Company 
        {
            get { return company; }
            set { company = value; }
        }
    }
}
