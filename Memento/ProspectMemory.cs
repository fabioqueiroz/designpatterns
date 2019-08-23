using System;
using System.Collections.Generic;
using System.Text;

namespace Memento
{
    /// <summary>

    /// The 'Caretaker' class

    /// </summary>

    public class ProspectMemory

    {

        private Memento _memento;



        // Property

        public Memento Memento

        {

            set { _memento = value; }

            get { return _memento; }

        }

    }
}
