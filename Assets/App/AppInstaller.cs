using Containers;
using Core;
using UnityEngine;

namespace App
{
    public sealed class AppInstaller : MonoBehaviour
    {
        private void Awake()
        {
            var context = new Context();
            context.Initialization();
            ContextProvider.SetInstance(context);
        }

        private void Start()
        {
            new ContainersInstaller().Install();
            new FortInstaller().Install();
            new GunsInstaller().Install();
            new FinderManagerInstaller().Install();
        }
    }
}