using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_13._2_AOI_Using_Builder_Pattern
{
    class AOIBuildDirector
    {
        public void Construct(AOIConfigBuilder configBuilder) 
        {
            // 假設硬體的啟動順序必須按照這樣的安排，否則會出現未知錯誤
            // 很神奇，有時改變啟動順序問題就不見了
            configBuilder.buildRobot();
            configBuilder.buildOpticalSensor();
            configBuilder.buildStage();
        }
    }
}
