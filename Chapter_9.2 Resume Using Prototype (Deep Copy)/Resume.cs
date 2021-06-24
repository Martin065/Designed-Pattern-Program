using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_9._2_Resume_Using_Prototype__Deep_Copy_
{
    class Resume : ICloneable
    {
        private string name;
        private string sex;
        private string age;
        private WorkExperience work;

        public Resume( string name) 
        {
            this.name = name;
            work = new WorkExperience();
        }
        private Resume(WorkExperience work) 
        {
            this.work = (WorkExperience)work.Clone();
        }
        public void SetPersonalInfo(string sex, string age) 
        {
            this.sex = sex;
            this.age = age;
        }
        public void SetWorkExperience(string workDate,string company) 
        {
            work.WorkDate = workDate;
            work.Company = company;
        }
        public void Display() 
        {
            Console.WriteLine("{0} {1} {2}" , name,sex,age);
            Console.WriteLine("WorkExperence : {0} {1}" , work.WorkDate , work.Company);
        }
        public object Clone()
        {
            Resume obj = new Resume(this.work);   // 這邊幫參考型別的物件"Experencework"建立了一個副本，並且也把參考重新導向了這個副本。
            obj.name = this.name;
            obj.sex = this.sex;
            obj.age = this.age;
            return obj;            
        }

    }
}
