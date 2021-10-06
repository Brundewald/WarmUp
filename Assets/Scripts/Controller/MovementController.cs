using UnityEngine;

namespace WarmUp 
{
    public class MovementController:IExecute, ICleanup 
    {
        private readonly Transform _player;
        private readonly IDataPlayer _playerData;
        private float _horizontal;
        private float _jump;
        private Vector3 _movementVector;
        private IUserProxy _horizontalInputProxy;
        private IUserProxy _jumpInputProxy;

        public MovementController((IUserProxy inputHorizontal, IUserProxy inputJump) input, Transform player, IDataPlayer playerData) 
        {
            _player = player;
            _playerData = playerData;
            _horizontalInputProxy = input.inputHorizontal;
            _jumpInputProxy = input.inputJump;
            _horizontalInputProxy.OnAxisChange += _horizontalInputProxy_OnAxisChange;
            _jumpInputProxy.OnAxisChange += _jumpInputProxy_OnAxisChange;
        }

        private void _jumpInputProxy_OnAxisChange(float value)
        {
            _horizontal = value;
        }

        private void _horizontalInputProxy_OnAxisChange(float value)
        {
            _jump = value;
        }

        public void Execute(float deltaTime) 
        {
            var speed = deltaTime * _playerData.Speed;
            _movementVector.Set(_jump * speed, _horizontal  * speed, 0);
            _player.localPosition += _movementVector;
        }

        public void Cleanup() 
        {
            _horizontalInputProxy.OnAxisChange -= _horizontalInputProxy_OnAxisChange;
            _jumpInputProxy.OnAxisChange -= _jumpInputProxy_OnAxisChange;
        }
    }

}
