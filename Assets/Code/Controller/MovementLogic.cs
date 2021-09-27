using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace WarmUp 
{
    public sealed class MovementLogic : IExecute, ICleanUp
    {
        private readonly Transform _unitTransform;
        private float _horizontal;
        private float _vertical;
        private Vector3 _movementVector;
        private IInputProxy _horizontalInputProxy;
        private IInputProxy _verticalInputProxy;
        [SerializeField] private float _speed = 5.0f;

        public MovementLogic((IInputProxy inputHorizontal, IInputProxy inputVertical) input, Transform unitTransform) 
        {
            _unitTransform = unitTransform;
            _horizontalInputProxy = input.inputHorizontal;
            _verticalInputProxy = input.inputVertical;
            _horizontalInputProxy.OnAxisChange += horizontalInputProxy_OnAxisChange;
            _verticalInputProxy.OnAxisChange += verticalInputProxy_OnAxisChange;

        }

        private void verticalInputProxy_OnAxisChange(float value)
        {
            _vertical = value;
        }

        private void horizontalInputProxy_OnAxisChange(float value)
        {
            _horizontal = value;
        }

        public void Execute(float deltaTime)
        {
            var speed = deltaTime * _speed;
            _movementVector.Set(_horizontal * speed, _vertical * speed, 0.0f);
            _unitTransform.localPosition += _movementVector;
        }

        public void CleanUp() 
        {
            _horizontalInputProxy.OnAxisChange -= horizontalInputProxy_OnAxisChange;
            _verticalInputProxy.OnAxisChange -= verticalInputProxy_OnAxisChange;
        }
    }

}
