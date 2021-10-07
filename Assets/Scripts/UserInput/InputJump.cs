using System;
using UnityEngine;

namespace WarmUp
{
    public class InputJump: IUserProxy
    {
        public event Action<float> OnAxisChange = delegate (float f) { };

        public void GetAxis() 
        {
            OnAxisChange.Invoke(Input.GetAxis(AxisManager.Jump));
        }
    }
}
