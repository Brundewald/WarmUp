using UnityEngine;

namespace WarmUp 
{
    public sealed class MovementLogic:IExecute, ICleanup 
    {
        private readonly IUserProxy _horizontalInputProxy;
        private readonly IUserProxy _jumpInputProxy;

        private readonly Transform _player;
        private readonly IDataPlayer _playerData;
        private readonly PlayerView _playerView;

        private float _horizontal;
        private float _jump;
        private Vector3 _movementVector;
        private Rigidbody _playerRigidbody;
        

        public MovementLogic((IUserProxy inputHorizontal, IUserProxy inputJump) input, Transform player, IDataPlayer playerData) 
        {
            _player = player;
            _playerData = playerData;
            _playerView = player.GetComponent<PlayerView>();
            _playerRigidbody = player.GetComponent<Rigidbody>();
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
            Movement(deltaTime);
        }

        private void Movement(float deltaTime)
        {
            var speed = deltaTime * _playerData.Speed;
            var doJump = _jump > 0;

            _movementVector.Set(_horizontal * speed, 0, 0);
            _player.localPosition += _movementVector;
                
            if (doJump && _playerView.OnGround)
            {
                _playerRigidbody.AddForce(0f, _playerData.JumpForce, 0f);
            }
        }

        public void Cleanup() 
        {
            _horizontalInputProxy.OnAxisChange -= HorizontalInputProxy_OnAxisChange;
            _jumpInputProxy.OnAxisChange -= JumpInputProxy_OnAxisChange;
        }
    }

}
