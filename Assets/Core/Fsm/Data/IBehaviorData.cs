using Fsm.Behavior.interfaces;
using Uit.Ai.Validators;

namespace Fsm.Data
{
    public interface IBehaviorData
    {
        IValidator Validator { get; }
        IBehavior Behavior { get; }
        void Execute();
    }
}