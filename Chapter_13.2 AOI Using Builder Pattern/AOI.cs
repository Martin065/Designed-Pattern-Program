using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_13._2_AOI_Using_Builder_Pattern
{
    class AOI
    {
        OpticalSensor opticalSensor;
        Stage stage;
        Robot robot;
        public void InitialOpticalSensor(OpticalSensor os) 
        {
            opticalSensor = os;
            opticalSensor.initial();
        }
        public void InitialStage(Stage st)
        {
            stage = st;
            stage.initial();
        }
        public void InitialRobot(Robot rb) 
        {
            robot = rb;
            robot.initial();
        }
        public void showCompomentList() 
        {
            Console.WriteLine(); Console.WriteLine("Compoment List------------------");
            opticalSensor.showCompomentInfo();
            stage.showCompomentInfo();
            robot.showCompomentInfo();
            Console.WriteLine();
        }
    }
}
