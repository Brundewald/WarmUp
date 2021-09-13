using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace WarmUp 
{
    public class PlayerControler : MonoBehaviour
    {
        private Rigidbody _rigidbody;
        private const string Horizontal = nameof(Horizontal);
        private const string Vertical = nameof(Vertical);
        [SerializeField]
        private float _speed = 1.0f;

        private void Start()
        {
            _rigidbody = GetComponent<Rigidbody>();
        }

       
        // Update is called once per frame
        private void Update()
        {
            Movement();
        }

        protected void Movement()
        {
            float movementH = Input.GetAxis(Horizontal);
            float movementV = Input.GetAxis(Vertical);

            Vector3 movement = new Vector3(movementH, movementV, 0.0f);

            _rigidbody.AddForce(movement * _speed);
        }
    }

}
