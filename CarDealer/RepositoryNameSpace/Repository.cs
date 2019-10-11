using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarNameSpace;

namespace RepositoryNameSpace
{
    public class Repository
    {
        List<CarInfo> CarList = new List<CarInfo>(); 
        public void Save(CarInfo c)
        {
            CarList.Add(c);
        }
    }
}
