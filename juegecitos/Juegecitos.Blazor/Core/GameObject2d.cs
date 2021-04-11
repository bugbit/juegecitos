using Juegecitos.Blazor.Core.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Juegecitos.Blazor.Core
{
    public class GameObject2d : GameObject
    {
        private Transform2d mTransform;

        public GameObject2d(Scene argScene, params Component[] argComponens) : base(argScene, argComponens) { }

        public Transform2d Transform
        {
            get => mTransform;
            set
            {
                mTransform = value;
                Transform.Owner = this;
            }
        }

        public override void Initialize()
        {
            base.Initialize();
            if (Transform == null)
                Transform = new Transform2d();
        }
    }
}
