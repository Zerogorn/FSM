using Fsm.Behavior;
using Fsm.Behavior.interfaces;
using Fsm.Data;

namespace Fsm
{
    public interface IFsmController
    {
        void SetDefaultBehavior<TBehavior>()
            where TBehavior : IBehavior;

        void AddBehavior<TBehavior>(IBehaviorData behavior)
            where TBehavior : IBehavior;

        void RemoveBehavior<TBehavior>()
            where TBehavior : IBehavior;

        void PushBehavior<TBehavior>()
            where TBehavior : IBehavior;
        void PopBehavior<TBehavior>()
            where TBehavior : IBehavior;

        void Execute();
    }
}