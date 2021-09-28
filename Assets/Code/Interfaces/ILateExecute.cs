using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace WarmUp 
{
    public interface ILateExecute : IController
    {
        void LateExecute(float deltaTime);
    }

}
