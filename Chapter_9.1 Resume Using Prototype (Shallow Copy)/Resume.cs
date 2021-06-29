using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_9._1_Resume_Using_Prototype__Shallow_Copy_
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
            return (object)this.MemberwiseClone();    // 淺複製
        }
        /* 
         * 因為Portotype Pattern實在太常使用了，所以微軟直接定義好IClonable讓大家可以直接實現這個Pattern，
         * 這個 Pattern 主要就是為了達成 clone 功能，讓使用者可以在物件複製後不必在對物件內的參數一個一個做設定，
         * 但其實主要的目的是為了提升物件建立的效能，有些物件建立非常耗時(執行new時必須執行建構式)，
         * 所以在初始化的資訊不發生變化的情況下，進行複製是最好的方法。
         * 但必須注意的一個點在於，如果複製時該物件內部欄位是"值類型"會直接複製，"參考類型"則是複製參考，而不是參考的物件本身，
         * 什麼意思呢？意思代表複製出來的物件與原始物件(被複製的物件)，都會對"參考類型"這個欄位參考到同一個物件，
         * 就像這個範例，這些Resume內的WorkExperence資訊是一個物件，他是屬於"參考類型"，因此最後c物件在做修改時，
         * a物件與b物件的WorkExperence也一同被修改了，因為他們都指向了同一個WorkExperence物件，
         * 反過來看"值類型"，儘管c物件做了修改，但a物件還是保有自己修改後的參數，
         * 因為STRING是屬於"值類型"的欄位，所以是各自獨立的。
        */
    }
}
