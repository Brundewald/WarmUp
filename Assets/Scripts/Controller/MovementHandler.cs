using UnityEngine;

namespace WarmUp 
{
    public class MovementLogic:IExecute, ICleanup 
    {
        private readonly Transform _player;
        private readonly IDataPlayer _playerData;
        private readonly PlayerView _playerView;
        private Rigidbody _playerRigidbody;
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
            _playerView = player.GetComponent<PlayerView>();
            _playerRigidbody = player.GetComponent<Rigidbody>();
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
            var doJump = _jump > 0;
            var speed = deltaTime * _playerData.Speed;
            _movementVector.Set(_horizontal * speed, 0, 0);
            _player.localPosition += _movementVector;

            if (_playerView.OnGround && doJump)
            {
                _playerRigidbody.AddForce(0, _playerData.JumpForce, 0);
            }
        }

        public void Cleanup() 
        {
            _horizontalInputProxy.OnAxisChange -= HorizontalInputProxy_OnAxisChange;
            _jumpInputProxy.OnAxisChange -= JumpInputProxy_OnAxisChange;
        }
    }

}
