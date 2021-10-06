namespace WarmUp
{
    public interface ILateExecute : IController
    {
        void LateExecute(float deltaTime);
    }
}
