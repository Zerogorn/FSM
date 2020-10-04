using Managers.ContainerManger;
using Managers.FinderManger;
using Managers.FortManger;
using Managers.GunsManger;

namespace Core
{
    public sealed class Context : IContext
    {
        private ContainerMangerInstaller _containerMangerInstaller;
        private GunsGeneratorInstaller _gunsGeneratorInstaller;
        private FortMangerInstaller _fortMangerInstaller;
        private FinderMangerInstaller _finderMangerInstaller;

        public IContainerManger ContainerManger { get; private set; }
        public IGunsItemManager GunsItemManager { get; private set; }
        public IFortManger FortManger { get; private set; }
        public IFinderManger FinderManger { get; private set; }

        public Context()
        {
            _containerMangerInstaller = new ContainerMangerInstaller();
            _gunsGeneratorInstaller = new GunsGeneratorInstaller();
            _fortMangerInstaller = new FortMangerInstaller();
            _finderMangerInstaller = new FinderMangerInstaller();
        }

        public void Initialization()
        {
            ContainerManger = _containerMangerInstaller.Install();
            GunsItemManager = _gunsGeneratorInstaller.Install(ContainerManger);
            FortManger = _fortMangerInstaller.Install(ContainerManger);
            FinderManger = _finderMangerInstaller.Install(ContainerManger);
        }
    }
}