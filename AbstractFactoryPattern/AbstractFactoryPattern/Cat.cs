using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryPattern
{
    public class Cat : Animal
    {
        public string speak()
        {
            return "Meow Meow Meow";
        }
    }
}
