using System;

namespace WarmUp
{
    public interface IUserProxy
    {
        event Action<float> OnAxisChange;
        void GetAxis();
    }
}
