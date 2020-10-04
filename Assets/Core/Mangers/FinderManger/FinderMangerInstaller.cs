using Managers.ContainerManger;
using Managers.FinderManger.Factory;

namespace Managers.FinderManger
{
    public sealed class FinderMangerInstaller
    {
        public IFinderManger Install(IContainerManger containerManger)
        {
            var finderFactory = new FinderFactory();
            var finderManger = new FinderManger(containerManger, finderFactory);

            finderFactory.Initialization();
            
            return finderManger;
        }
    }
}