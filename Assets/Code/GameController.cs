using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace WarmUp 
{
    public class GameController : MonoBehaviour
    {
        private InteractiveObject[] _interactiveObjects;
        private MovementLogic _movement;
        [SerializeField]
        internal Transform _sphereTransform;
       
        
        private void Awake()
        {
            _movement = new MovementLogic();
            _interactiveObjects = FindObjectsOfType<InteractiveObject>();
        }

        private void Update()
        {            
            Action(_movement);
        }

        void Action(IMove move)
        {
            move.Movement();
        }

    }

}
