using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace WarmUp 
{
    public sealed class InputInitialization : IInitialization 
    {
        private IInputProxy _pcInputHorizontal;
        private IInputProxy _pcInputVertical;

        public InputInitialization() 
        {
            _pcInputHorizontal = new PCInputHorizontal();
            _pcInputVertical = new PCInputVertical();
        }

        public void Initialization()
        {
        }

        public (IInputProxy inputHorizontal, IInputProxy inputVertical) GetInput()
        {
            (IInputProxy inputHorizontal, IInputProxy inputVertical) result = (_pcInputHorizontal, _pcInputVertical);
            return result;
        }
    }

}
