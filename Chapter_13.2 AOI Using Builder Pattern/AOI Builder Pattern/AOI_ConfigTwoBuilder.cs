using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_13._2_AOI_Using_Builder_Pattern
{
    class AOI_ConfigTwoBuilder : AOIConfigBuilder
    {
        private AOI AOIObject = new AOI();
        public override void buildOpticalSensor()
        {
            OpticalBrand_B opticalBrandB = new OpticalBrand_B();
            AOIObject.InitialOpticalSensor(opticalBrandB);
        }
        public override void buildRobot()
        {
            RobotBrand_Z robotBrandZ = new RobotBrand_Z();
            AOIObject.InitialRobot(robotBrandZ);
        }
        public override void buildStage()
        {
            StageBrand_P stageBrandP = new StageBrand_P();
            AOIObject.InitialStage(stageBrandP);
        }
        public override AOI getResult()
        {
            return AOIObject;
        }
    }
}
