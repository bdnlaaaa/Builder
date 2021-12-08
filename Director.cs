using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class Director
    {
        public Chair MakeChair(ChairBuilder chair)
        {
            chair.CreateNewChair();
            chair.SetMainMaterials();
            chair.SetMainColors();
            chair.SetShape();

            return chair.GetChair();
        }
    }
}
