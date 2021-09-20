using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace WarmUp 
{
    public abstract class InteractiveObject : MonoBehaviour, IInteractable
    {
        public bool IsInteractable { get; }
        protected abstract void Interaction();

        private void Start()
        {
            Action();
        }

        public void Action() 
        {
            if (TryGetComponent(out Renderer renderer)) 
            {
                renderer.material.color = Random.ColorHSV();
            }
        }
    }
}

