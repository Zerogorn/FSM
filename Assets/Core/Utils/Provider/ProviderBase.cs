using System;

namespace Core.Utils.Provider
{
    public abstract class ProviderBase<TInstance, TInterface>
        where TInstance : TInterface
    {
        protected static TInstance _instance;

        public static void SetInstance(TInstance instance)
        {
            _instance = instance;
        }

        public static TInterface Instance => _instance;
    }
}