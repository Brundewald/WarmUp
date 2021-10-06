namespace WarmUp
{
    public sealed class InputController:IExecute
    {
        private readonly IUserProxy _horizontal;
        private readonly IUserProxy _jump;

        public InputController((IUserProxy inputHorizontal, IUserProxy inputJump) input) 
        {
            _horizontal = input.inputHorizontal;
            _jump = input.inputJump;
        }

        public void Execute(float deltaTime) 
        {
            _horizontal.GetAxis();
            _jump.GetAxis();
        }
    }
}
