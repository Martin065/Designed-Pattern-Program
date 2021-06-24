using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_9._2_Resume_Using_Prototype__Deep_Copy_
{
    class WorkExperience : ICloneable
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
        public object Clone()
        {
            return (object)this.MemberwiseClone();    // 如果想要讓你已經參考的物件不是被淺複製(只複製參考)，那麼該物件就也要實作ICloneable
        }
        /*
         * 被參考的物件如果也做了淺複製，那麼在呼叫端就會真正把被參考的物件複製出來，並把參考指向新的物件去。
         * 但我疑惑的是，因為這個"被參考的物件"的欄位也是"實值類型"，所以作者在這邊進行淺複製是OK的，如果這邊的資料又是"參考類型"呢？
         * 就會變成作者提到的多層參考的問題，但作者點到為止，沒有更深入進行說明。
         * 我找到一些資訊，可以參考 [C#.NET] 利用序列化進行類別深複製 一文，
         * 會以原先Chapter_9.1這個例子再進行修改(預計增加新的Chapter_9.3)，觀看是否可進行兩層以上的深複製。
         */
    }
}
