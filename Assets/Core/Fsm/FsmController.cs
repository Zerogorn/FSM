using System;
using System.Collections.Generic;
using Fsm.Behavior;
using Fsm.Behavior.interfaces;
using Fsm.Data;
using Uit.Ai.Validators;

namespace Fsm
{
    public sealed class FsmController : IFsmController
    {
        private readonly IDictionary<Type, IBehaviorData> _behaviors;
        private readonly Stack<IBehaviorData> _behaviorsStack;
        
        public FsmController()
        {
            _behaviors = new Dictionary<Type, IBehaviorData>();
            _behaviorsStack = new Stack<IBehaviorData>();
            _behaviorsStack.Push(new BehaviorData(new NullableValidator(), new NullableBehavior()));
        }

        public void SetDefaultBehavior<TBehavior>()
            where TBehavior : IBehavior
        {
            _behaviorsStack.Push(_behaviors[typeof(TBehavior)]);
        }

        public void AddBehavior<TBehavior>(IBehaviorData behavior)
            where TBehavior : IBehavior
        {
            var behaviorType = typeof(TBehavior);

            _behaviors.Add(behaviorType, behavior);
        }

        public void RemoveBehavior<TBehavior>()
            where TBehavior : IBehavior
        {
            var behaviorType = typeof(TBehavior);

            _behaviors.Remove(behaviorType);
        }

        public void PopBehavior<TBehavior>()
            where TBehavior : IBehavior
        {
            var behaviorType = typeof(TBehavior);

            _behaviors[behaviorType].Behavior.Dispose();
            _behaviorsStack.Pop();
        }

        public void PushBehavior<TBehavior>()
            where TBehavior : IBehavior
        {
            var behaviorType = typeof(TBehavior);

            _behaviorsStack.Push(_behaviors[behaviorType]);
        }

        public void Execute()
        {
            _behaviorsStack.Peek()
                           .Execute();
        }
    }
}