using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_13._2_AOI_Using_Builder_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            AOIBuildDirector aOIBuildDirector = new AOIBuildDirector();
            AOI aoiProduct;
            AOIConfigBuilder aoiConfig;
            // 客戶Martin 機台的配置需求為 ConfigOne
            aoiConfig = new AOI_ConfigOneBuilder();
            aOIBuildDirector.Construct(aoiConfig);
            aoiProduct = aoiConfig.getResult();
            aoiProduct.showCompomentList();

            // 客戶Leo 機台的配置需求為 ConfigTwo
            aoiConfig = new AOI_ConfigTwoBuilder();
            aOIBuildDirector.Construct(aoiConfig);
            aoiProduct = aoiConfig.getResult();
            aoiProduct.showCompomentList();

            Console.Read();
        }
    }
}
