using System;
using UnityEngine;

namespace WarmUp
{
    public sealed class InputHorizontal:IUserProxy
    {
        public event Action<float> OnAxisChange = delegate (float f) { };

        public void GetAxis() 
        {
            OnAxisChange.Invoke(Input.GetAxis(AxisManager.Horizontal));
        }
    }
}
