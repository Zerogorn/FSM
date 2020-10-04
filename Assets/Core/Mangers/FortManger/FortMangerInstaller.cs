using Managers.ContainerManger;
using Managers.FortManger.Factory;

namespace Managers.FortManger
{
    public sealed class FortMangerInstaller
    {
        public IFortManger Install(IContainerManger containerManger)
        {
            var fortFactory = new FortFactory();
            var fortManger = new FortManger(containerManger, fortFactory);

            fortFactory.Initialization();

            return fortManger;
        }
    }
}