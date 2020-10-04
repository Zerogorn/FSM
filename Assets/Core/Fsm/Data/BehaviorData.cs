using Fsm.Behavior.interfaces;
using Uit.Ai.Validators;

namespace Fsm.Data
{
    public sealed class BehaviorData : IBehaviorData
    {
        private IValidator _validator;
        private IBehavior _behavior;
        
        public BehaviorData(IValidator validator, IBehavior behavior)
        {
            _validator = validator;
            _behavior = behavior;
        }
        
        public IValidator Validator => _validator;
        public IBehavior Behavior => _behavior;

        public void Execute()
        {
            _behavior.Execute();
            _validator.IsValid();
        }
    }
}