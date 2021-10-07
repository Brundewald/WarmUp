using UnityEngine;

namespace WarmUp 
{
    public class EndGameLogic : ILateExecute
    {
        private const float _rayDistance = 0.1f;
        private readonly Vector3 _rayDirection = new Vector3(0f,-1f, 0f);
        private readonly FinishPlatformView _finishPlatform;
        private readonly Transform _playerTransform;
        private readonly PlayerView _player;
        private readonly Collider _finishCollider;

        public EndGameLogic() 
        {
            _player = Object.FindObjectOfType<PlayerView>();
            _finishPlatform = Object.FindObjectOfType<FinishPlatformView>();
            _playerTransform = _player.GetComponent<Transform>();
           _finishCollider = _finishPlatform.GetComponent<Collider>();
        }

        public void LateExecute(float deltaTime)
        {
            FinishTrigger();
        }

        private void FinishTrigger()
        {
            Ray ray = new Ray(_playerTransform.position, _rayDirection);

            if (Physics.Raycast(ray, _rayDistance))
            {
               Debug.Log("You Win");
            }
        }
    }

}
