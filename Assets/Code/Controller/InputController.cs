using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace WarmUp 
{
    public sealed class InputController : IExecute
    {
        private readonly IInputProxy _horizontal;
        private readonly IInputProxy _vertical;

        public InputController((IInputProxy inputHorizontal, IInputProxy inputVertical) input) 
        {
            _horizontal = input.inputHorizontal;
            _vertical = input.inputVertical;
        }

        public void Execute (float deltaTime) 
        {
            _horizontal.GetAxis();
            _vertical.GetAxis();
        }
    }

}
