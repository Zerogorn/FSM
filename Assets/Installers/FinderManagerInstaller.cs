using Core;
using Managers.FinderManger;

namespace Containers
{
    public sealed class FinderManagerInstaller : IInstallers
    {
        private IFinderManger finderManger => ContextProvider.Instance.FinderManger;

        public void Install()
        {
            finderManger.CreateFinder();
        }
    }
}