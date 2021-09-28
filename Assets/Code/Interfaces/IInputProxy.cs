using System;

namespace WarmUp
{
    public interface IInputProxy 
    {
        event Action<float> OnAxisChange;
        void GetAxis();
    }
}
