using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataGrid
{ 
    public class Cars<T>
    {
        public Cars()
        {
           
        }

        private List<Car> col = new List<Car>();

        public void add(Car pCar)
        {
            col.Add(pCar);
        }


        public Car item(int pID)
        {
            return col[pID];
        }


    }
}
