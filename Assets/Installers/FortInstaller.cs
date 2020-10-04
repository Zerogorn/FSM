using Core;
using Managers.FortManger;

namespace Containers
{
    public sealed class FortInstaller : IInstallers
    {
        private IFortManger fortManger => ContextProvider.Instance.FortManger;

        public void Install()
        {
            fortManger.CreateFort();
        }
    }
}