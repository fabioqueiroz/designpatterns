using System;
using System.Collections.Generic;
using System.Text;

namespace Mediator
{
    public class Component2 : IComponent
    {
        public void SetState(object state)
        {
            Console.WriteLine(state);
        }
    }
}
