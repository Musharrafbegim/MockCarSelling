using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Mock
{

    public class CarModel
    {
        
        public int ID
        {
            get;
            set;
        }

        public string Model
        {
            get;
            set;
        }

        public int Price
        {
            get;
            set;
        }

        public int ProdYear
        {
            get;
            set;
        }

        public condtion Condition
        {
            get;
            set;
        }

        public string Brand
        {
            get;
            set;
        }
        public enum condtion
        {
            Excellent = 0,
            Good = 1,
            Bad = 2
        }
    }
}