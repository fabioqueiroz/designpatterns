using System;
using System.Collections.Generic;
using System.Text;

namespace Mediator
{
    public class Component1 : IComponent
    {
        public void SetState(object state)
        {
            Console.WriteLine(state);
        }

        //void IComponent.SetState(object state) => Console.WriteLine(state);
    }
}
