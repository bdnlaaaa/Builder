using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public abstract class ChairBuilder
    {
        protected Chair ChairObject;
        public abstract void SetMainMaterials();
        public abstract void SetMainColors();
        public abstract void SetShape();
        public void CreateNewChair()
        {
            ChairObject = new Chair();
        }
        public Chair GetChair()
        {
            return ChairObject;
        }
    }
}
