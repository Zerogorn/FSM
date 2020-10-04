using Managers.ContainerManger;
using Managers.GunsManger.Factory;
using Managers.GunsManger.Model;
using Managers.GunsManger.Service;

namespace Managers.GunsManger
{
    public sealed class GunsGeneratorInstaller
    {
        public IGunsItemManager Install(IContainerManger containerManger)
        {
            var gunsFactory = new GunsFactory();
            var gunsModel = new GunsModel();
            var gunGeneratorService = new GunGeneratorService(gunsFactory, gunsModel);
            var gunsItemManager = new GunsItemManager(containerManger, gunsModel, gunGeneratorService);

            gunsFactory.Initialization();
            
            return gunsItemManager;
        }
    }
}