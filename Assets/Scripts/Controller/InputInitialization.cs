using UnityEngine;

namespace WarmUp
{
    public sealed class InputInitialization:IInitialize
    {
        private IUserProxy _inputHorizontal;
        private IUserProxy _inputJump;

        public InputInitialization() 
        {
            _inputHorizontal = new InputHorizontal();
            _inputJump = new InputJump();
        }

        public (IUserProxy inputHorizontal, IUserProxy inputJump) GetInput() 
        {
            (IUserProxy inputHorizontal, IUserProxy inputJump) result = (_inputHorizontal, _inputJump);
            return result;
        }
        public void Initialize() 
        {
        }
    }
}
