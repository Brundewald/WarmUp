using UnityEngine;

namespace WarmUp 
{
    public class MovementLogic:IExecute, ICleanup 
    {
        private readonly Transform _player;
        private readonly IDataPlayer _playerData;
        private float _horizontal;
        private float _jump;
        private Vector3 _movementVector;
        private readonly IUserProxy _horizontalInputProxy;
        private readonly IUserProxy _jumpInputProxy;

        public MovementLogic((IUserProxy inputHorizontal, IUserProxy inputJump) input, Transform player, IDataPlayer playerData) 
        {
            _player = player;
            _playerData = playerData;
            _horizontalInputProxy = input.inputHorizontal;
            _jumpInputProxy = input.inputJump;
            _horizontalInputProxy.OnAxisChange += HorizontalInputProxy_OnAxisChange;
            _jumpInputProxy.OnAxisChange += JumpInputProxy_OnAxisChange;
        }

        private void HorizontalInputProxy_OnAxisChange(float value)
        {
            _horizontal = value;
        }
        private void JumpInputProxy_OnAxisChange(float value)
        {
            _jump = value;
        }

        public void Execute(float deltaTime) 
        {
            var speed = deltaTime * _playerData.Speed;
            _movementVector.Set(_horizontal * speed, _jump  * speed, 0);
            _player.localPosition += _movementVector;
        }

        public void Cleanup() 
        {
            _horizontalInputProxy.OnAxisChange -= HorizontalInputProxy_OnAxisChange;
            _jumpInputProxy.OnAxisChange -= JumpInputProxy_OnAxisChange;
        }
    }

}
