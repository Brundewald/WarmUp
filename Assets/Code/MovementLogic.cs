using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace WarmUp 
{
    public sealed class MovementLogic : GameController, IMove
    {
       
        private const string Horizontal = nameof(Horizontal);
        private const string Vertical = nameof(Vertical);
        [SerializeField]
        private float _speed = 1.0f;
        

        public void Movement()
        {           
            float movementH = Input.GetAxis(Horizontal);
            float movementV = Input.GetAxis(Vertical);

            Vector3 movement = new Vector3(movementH, movementV, 0.0f);

            _sphereTransform.Translate(movement*_speed*Time.deltaTime);
        }
    }

}
