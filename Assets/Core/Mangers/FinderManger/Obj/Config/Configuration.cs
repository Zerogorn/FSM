using System;
using UnityEngine;

namespace Managers.FinderManger.Obj.Config
{
    [Serializable]
    public sealed class Configuration : IConfiguration
    {
        [SerializeField]
        private float moveSpeed = 0f;
        [SerializeField]
        private float runSpeed = 0f;
        [SerializeField]
        private float returnSpeed = 0f;
        [SerializeField]
        private float runDistance = 0f;

        public float MoveSpeed => moveSpeed;
        public float RunSpeed => runSpeed;
        public float ReturnSpeed => returnSpeed;
        public float RunDistance => runDistance;
    }
}