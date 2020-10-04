using System;
using Fsm.Behavior.interfaces;

namespace Fsm.Behavior
{
    public abstract class BaseBehavior : IBehavior
    {
        public void Dispose()
        {
            Push = null;
            Pop = null;
        }

        public event Action<Type> Push;
        public event Action Pop;

        public abstract void Execute();
    }
}