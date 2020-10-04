using UnityEngine;

namespace Managers.Factory
{
    public sealed class GeneratorFactory<TObj>
        where TObj : Object
    {
        private TObj _obj;

        public TObj Obj => _obj;

        public void Initialization()
        {
            var path = typeof(TObj).Name;
            _obj = Resources.Load<TObj>(path);
        }
    }
}