using Managers.FinderManger.Obj.Config;
using Managers.FinderManger.View;
using UnityEngine;

namespace Managers.FinderManger.Obj
{
    [CreateAssetMenu(menuName = "FinderItem", fileName = "FinderObj")]
    public sealed class FinderObj : ScriptableObject
    {
        [SerializeField]
        private FinderController _finderController = null;
        [SerializeField]
        private Configuration _configuration = null;

        public FinderController FinderController => _finderController;
        public Configuration Configuration => _configuration;
    }
}