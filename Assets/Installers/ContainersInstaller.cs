using Core;
using Managers.ContainerManger;
using Managers.ContainerManger.Controllers;

namespace Containers
{
    public sealed class ContainersInstaller : IInstallers
    {
        private IContainerManger ContainerManger => ContextProvider.Instance.ContainerManger;

        public void Install()
        {
            ContainerManger.Add<GunContainer>(0);
            ContainerManger.Add<FindersContainer>(1);
            ContainerManger.Add<FortContainer>(2);
        }
    }
}