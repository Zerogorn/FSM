using Managers.FortManger.Item;
using UnityEngine;

namespace Managers.FortManger.Obj
{
    [CreateAssetMenu(menuName = "FortItems", fileName = "FortObj")]
    public class FortObj : ScriptableObject
    {
        [SerializeField] 
        private FortView _fortView;

        public FortView FortView => _fortView;
    }
}