using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class Chair
    {
        public string MainMaterials { get; set; }
        public string MainColors { get; set; }
        public string Shape { get; set; }

        public void ShowChair()
        {
            Console.WriteLine("Main materials: " + MainMaterials);
            Console.WriteLine("Main colors: " + MainColors);
            Console.WriteLine("Shape: " + Shape);
        }
    }
}
