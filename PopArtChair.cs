using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    class PopArtChair : ChairBuilder
    {
        public override void SetMainMaterials()
        {
            ChairObject.MainMaterials = "Leather, plastic or some kind of glossy fabric";
        }
        public override void SetMainColors()
        {
            ChairObject.MainColors = "Vibrant colors that will attract attention";
        }
        public override void SetShape()
        {
            ChairObject.Shape = "Shape of lips";
        }
    }
}
