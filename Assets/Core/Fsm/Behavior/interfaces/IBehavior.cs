using System;

namespace Fsm.Behavior.interfaces
{
    public interface IBehavior : IDisposable
    {
        void Execute();
    }
}