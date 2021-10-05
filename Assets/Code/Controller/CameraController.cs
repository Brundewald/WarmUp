using UnityEngine;

namespace WarmUp
{
    public sealed class CameraController: ILateExecute
    {
        private readonly Transform _player;
        private readonly Transform _mainCamera;
        private readonly Vector3 _offset;

        public CameraController(Transform player, Transform Camera) 
        {
            _player = player;
            _mainCamera = _mainCamera;
            _offset = _mainCamera.position - _player.position;
        }

        public void LateExecute(float deltaTime) 
        {
            _mainCamera.position = _player.position + _offset;
        }

    }
}
