using UnityEngine;

namespace WarmUp
{
    public sealed class PlayerView : MonoBehaviour
    {
        private bool _onGround;
        private bool _onFinishPlatform;

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
            if (other != null)
            {
                if (other.GetComponent<FinishPlatformView>())
                {
                    _onFinishPlatform = true;
                }
            }
        }

        public bool OnGround => _onGround;
        public bool OnFinishPlatform => _onFinishPlatform;
    }
}