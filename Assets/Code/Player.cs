using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace WarmUp 
{
    public sealed class Player : MovementLogic
    {
        private void FixedUpdate()
        {
            Movement();
        }
    }
}
