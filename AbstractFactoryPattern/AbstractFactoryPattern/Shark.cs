using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryPattern
{
    public class Shark : Animal
    {
        public string speak()
        {
            return "Don't speak !!! Only kill!";
        }
    }
}
