using System;
using System.Collections.Generic;
using System.Text;

namespace Factory
{
    public class WineFactory
    {
        private IWine _wine;
        public WineFactory(WineType typeOfWine)
        {
            switch (typeOfWine)
            {
                case WineType.Bordeaux:
                    _wine = new Bordeaux();
                    break;
                case WineType.Rioja:
                    _wine = new Rioja();
                    break;
                case WineType.Porto:
                    _wine = new Porto();
                    break;
                default:
                    _wine = new Bordeaux();
                    break;
            }
        }

        public string CheckWineTaste()
        {
            return _wine.Taste();
        }
    }
}
