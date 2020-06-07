using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryPattern
{
    public class Dog : Animal
    {
        public string speak()
        {
            return "Bark Bark";
        }
    }
}
