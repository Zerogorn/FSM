using Managers.ContainerManger;
using Managers.FinderManger;
using Managers.FortManger;
using Managers.GunsManger;

namespace Core
{
    public interface IContext
    {
        IContainerManger ContainerManger { get; }
        IGunsItemManager GunsItemManager { get; }
        IFortManger FortManger { get; }
        IFinderManger FinderManger { get;  }
    }
}