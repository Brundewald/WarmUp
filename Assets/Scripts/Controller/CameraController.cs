using UnityEngine;

namespace WarmUp
{
    public sealed class CameraController: ILateExecute
    {
        private readonly Transform _player;
        private readonly Transform _mainCamera;
        private readonly Vector3 _offset;

        public CameraController(Transform player, Transform mainCamera) 
        {
            _player = player;
            _mainCamera = mainCamera;
            _offset = new Vector3(0f, 0f, -3f);
        }

        public void LateExecute(float deltaTime) 
        {
            _mainCamera.position = _player.position + _offset;
        }

    }
}
