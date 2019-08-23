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
        public List<Memento> mementos = new List<Memento>();

        // Property

        public Memento Memento
        {
            set { _memento = value; }

            get { return _memento; }
        }

        public void AddMemento(Memento state)
        {
            mementos.Add(state);
        }
    }
}
