using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_13._2_AOI_Using_Builder_Pattern
{
    class AOI_ConfigOneBuilder : AOIConfigBuilder
    {
        private AOI AOIObject = new AOI();        
        public override void buildOpticalSensor()
        {
            OpticalBrand_A opticalBrandA = new OpticalBrand_A();
            AOIObject.InitialOpticalSensor(opticalBrandA);
        }
        public override void buildRobot()
        {
            RobotBrand_Y robotBrandY = new RobotBrand_Y();
            AOIObject.InitialRobot(robotBrandY);
        }
        public override void buildStage()
        {
            StageBrand_O stageBrandO = new StageBrand_O();
            AOIObject.InitialStage(stageBrandO);
        }
        public override AOI getResult()
        {
            return AOIObject;
        }
    }
}
