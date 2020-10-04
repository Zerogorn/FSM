using System.Collections.Generic;
using Managers.GunsManger.Item;
using UnityEngine;

namespace Managers.GunsManger.Obj
{
    [CreateAssetMenu(menuName = "GunsItem", fileName = "GunsObj")]
    public sealed class GunsObj : ScriptableObject
    {
        [SerializeField]
        private List<ItemView> _itemViews = new List<ItemView>();

        public List<ItemView> ItemViews => _itemViews;
    }
}