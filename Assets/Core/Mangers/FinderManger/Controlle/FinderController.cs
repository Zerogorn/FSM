using Core;
using Managers.FinderManger.Obj.Config;
using Managers.FortManger.Item;
using Managers.GunsManger;
using Managers.GunsManger.Item;

using UnityEngine;

namespace Managers.FinderManger.View
{
    public sealed class FinderController : MonoBehaviour, IFinderController
    {
        private IItemView _item;
        private IConfiguration _configuration;

        private IGunsItemManager _gunsItemManager => ContextProvider.Instance.GunsItemManager;
        public IConfiguration Configuration => _configuration;

        public void Initialization(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public bool HasItem()
        {
            return _item != null;
        }

        public Vector2 GetPosition()
        {
            return transform.localPosition;
        }

        public void SetRotation(Quaternion quaternion)
        {
            transform.localRotation = quaternion;
        }

        public void SetPosition(Vector2 position)
        {
            transform.localPosition = position;
        }

        public void MoveForward(float speed)
        {
            var delta = transform.up * (Time.deltaTime * speed) * -1;
            transform.localPosition = transform.localPosition + delta;
        }

        private void OnTriggerEnter2D(Collider2D other)
        {
            if (other.gameObject.TryGetComponent(out ItemView itemView))
            {
                if (_item == null)
                {
                    _item = itemView;
                    itemView.gameObject.SetActive(false);
                }
            }
            else if (other.gameObject.TryGetComponent(out FortView _))
            {
                if (_item != null)
                {
                    _gunsItemManager.RemoveGun(_item);
                    _item = null;
                }
            }
        }
    }
}