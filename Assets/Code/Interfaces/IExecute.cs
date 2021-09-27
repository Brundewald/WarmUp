using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace WarmUp 
{
    public interface IExecute : IController
    {
        void Execute(float deltaTime);
    }

}
