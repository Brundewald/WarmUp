using UnityEngine;

namespace WarmUp 
{
    public sealed class PlayerPositionReseter:ILateExecute
    {
        private const float _fallDepth = -10;

        private Transform _player;
        private Vector3 _startPoint;
        private Vector3 _offset;

        public PlayerPositionReseter(Transform player, Vector3 startPoint, Vector3 offset)
        {
            _player = player;
            _startPoint = startPoint;
            _offset = offset;
        }

        public void LateExecute(float deltaTime)
        {
            CheckPlayerPosition();
        }

        private void CheckPlayerPosition()
        {
            if (_player.position.y < _fallDepth)
            {
                _player.position = _startPoint + _offset;
            }
        }
    }
}
