using Fsm;
using Managers.FinderManger.View;

namespace Uit.Ai.Validators
{
    public sealed class NullableValidator : ValidatorBase
    {
        public NullableValidator()
            : base(null, null)
        {
            
        }

        public NullableValidator(IFinderController finderController, IFsmController fsmController)
            : base(finderController, fsmController)
        {
        }

        public override void IsValid()
        {
            
        }
    }
}