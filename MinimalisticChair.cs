using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    class MinimalisticChair : ChairBuilder
    {
        public override void SetMainMaterials()
        {
            ChairObject.MainMaterials = "Wood or steel without any engravings";
        }
        public override void SetMainColors()
        {
            ChairObject.MainColors = "Neutral colors";
        }
        public override void SetShape()
        {
            ChairObject.Shape = "Simple shape with straight lines";
        }
    }
}
