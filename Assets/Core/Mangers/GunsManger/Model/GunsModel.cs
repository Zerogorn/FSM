using System.Collections.Generic;
using System.Linq;
using Managers.GunsManger.Item;
using UnityEngine;

namespace Managers.GunsManger.Model
{
    public sealed class GunsModel : IGunsModel
    {
        private readonly List<IItemView> _items;

        public GunsModel()
        {
            _items = new List<IItemView>();
        }

        public void Add(IItemView itemView)
        {
            _items.Add(itemView);
        }

        public void Remove(IItemView itemView)
        {
            _items.Remove(itemView);
        }

        public Vector2 GetNearestItem(Vector2 fromPoint)
        {
            var nearestItem = _items.First();
            var nearestDistance = Vector2.Distance(fromPoint, nearestItem.GetPosition());

            _items.ForEach(item =>
            {
                var distance = Vector2.Distance(fromPoint, item.GetPosition());

                if (distance.CompareTo(nearestDistance) == -1)
                {
                    nearestItem = item;
                    nearestDistance = distance;
                }
            });

            return nearestItem.GetPosition();
        }

        public int CountItem()
        {
            return _items.Count;
        }
    }
}