using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace WarmUp 
{    public sealed class GoodBonusLogic : InteractiveObject, IEquatable<GoodBonusLogic>
    {
        public int Point;
        private Material _material;

        private void Awake()
        {
            _material = GetComponent<Renderer>().material;
        }

        protected override void Interaction() 
        {
            _view.Display(Point);
        }

        public bool Equals(GoodBonusLogic other) 
        {
            return Point == other.Point;
        }
    }
}