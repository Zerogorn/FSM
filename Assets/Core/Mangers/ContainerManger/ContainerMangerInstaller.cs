using Managers.ContainerManger.Factory;

namespace Managers.ContainerManger
{
    public sealed class ContainerMangerInstaller
    {
        public IContainerManger Install()
        {
            var containerFactory = new ContainerFactory();
            var containerManger = new ContainerManger(containerFactory);

            return containerManger;
        }
    }
}