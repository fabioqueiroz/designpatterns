using System;
using System.Collections.Generic;
using System.Text;

namespace Factory
{
    public class Rioja : IWine
    {
        public void Drink()
        {
            throw new NotImplementedException();
        }

        public string Taste()
        {
            return "Tastes like Spain";
        }
    }
}
