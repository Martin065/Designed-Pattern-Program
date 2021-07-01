using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_10._2_Camera_Initial_Using_Template_Method
{
    abstract class Camera
    {
        public abstract void Connect();
        public abstract void SetParameter();
        public abstract void StartCapture();

        
        public void InitialCamera()  
        {
            Connect();
            SetParameter();
            StartCapture();
        }
    }
    // InitialCamera Function定義了每台相機都要執行的步驟，且順序不會被變動，也不會被Override
    // 很好的規範了大架構的流程，而實際細節則留給子類別再各別實現
}
