using System;
using System.Collections.Generic;
using System.Text;

namespace Mediator
{
    public class Mediator
    {
        public IComponent Component1 { get; set; }
        public IComponent Component2 { get; set; }

        public Mediator()
        {
            Component1 = new Component1(); 
            Component2 = new Component2();
        }

        public void ChangeState(object state)
        {
            this.Component1.SetState(state);
            this.Component2.SetState(state);
        }
    }
}
