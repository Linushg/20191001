using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarNameSpace
{
        public class CarInfo
        {
            public string Make { get; set; }
            public string Model { get; set; }
            public string Regnr { get; set; }
            public string Kilometer { get; set; }
            public string Price { get; set; }

            public override string ToString()
            {
              return string.Format("Make: {0} Model: {1} Regnr: {2} Kilometer: {3} Price: {4}", Make, Model, Regnr, Kilometer, Price);
            }

        }
    
}

