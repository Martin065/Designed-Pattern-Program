using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_13._2_AOI_Using_Builder_Pattern
{
    abstract class AOIConfigBuilder
    {
        public abstract void buildOpticalSensor();
        public abstract void buildStage();
        public abstract void buildRobot();
        public abstract AOI getResult();
    }
}
