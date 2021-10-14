using UnityEngine;

namespace WarmUp
{
    public class PlayerView : MonoBehaviour
    {
        private bool _onGround;
        private bool _isFinished;

        private void OnCollisionStay()
        {
            _onGround = true;
        }

        private void OnCollisionExit()
        {
            _onGround = false;
        }

        private void OnTriggerEnter(Collider other)
        {
            if (other.GetComponent<FinishPlatformView>())
            {
                _isFinished = true;
            }
        }

        public bool OnGround => _onGround;
        public bool IsFinished => _isFinished;
    }
}