using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;                                        // 使用 MemoryStream
using System.Runtime.Serialization;                     // 使用 IFormatter
using System.Runtime.Serialization.Formatters.Binary;   // 使用 BinaryFormatter

namespace Chapter_9._4_Resume_Using_Prototype__Deep_Copy_TwoLayer_
{
    [Serializable]
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
            using (var memory = new MemoryStream())
            {
                IFormatter formatter = new BinaryFormatter();
                formatter.Serialize(memory, this);
                memory.Seek(0, SeekOrigin.Begin);
                return formatter.Deserialize(memory);
            }            
        }
        
    }
}
