using Fsm.Behavior.interfaces;
using Fsm.Data;

namespace Fsm.Extension
{
    public static class FsmExtension
    {
        public static void AddBehaviorDataToFsmController<TBehavior>(this IBehaviorData behaviorData, IFsmController fsmController)
            where TBehavior : IBehavior
        {
            fsmController.AddBehavior<TBehavior>(behaviorData);
        }
    }
}