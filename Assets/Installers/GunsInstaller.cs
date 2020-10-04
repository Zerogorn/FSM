using Core;
using Managers.GunsManger;

namespace Containers
{
    public sealed class GunsInstaller : IInstallers
    {
        private IGunsItemManager _gunsItemManager = ContextProvider.Instance.GunsItemManager;

        public void Install()
        {
            _gunsItemManager.CreateGuns();
        }
    }
}