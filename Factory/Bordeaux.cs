﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Factory
{
    public class Bordeaux : IWine
    {
        public void Drink()
        {
            throw new NotImplementedException();
        }

        public string Taste()
        {
            return "Red and dense";
        }
    }
}
