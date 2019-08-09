using System;
using System.Collections.Generic;
using System.Text;

namespace Factory
{
    public class Porto : IWine
    {

        public void Drink()
        {
            throw new NotImplementedException();
        }

        public string Taste()
        {
            return "Portuguese taste";
        }
    }
}
