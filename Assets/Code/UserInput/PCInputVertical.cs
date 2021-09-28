using System;
using UnityEngine;

namespace WarmUp
{
    public class PCInputVertical : IInputProxy
    {
        public event Action<float> OnAxisChange = delegate (float f) {};

        public void GetAxis() 
        {
            OnAxisChange.Invoke(Input.GetAxis(InputAxisManager.Vertical));
        }
    }
}
