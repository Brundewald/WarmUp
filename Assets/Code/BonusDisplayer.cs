using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace WarmUp 
{
    public class BonusDisplayer : IView
    {
        private Text _text;
        private int _point;

        public DisplayBonuses()
        {
            _text = Object.FindObjectOfType<Text>();
        }

        public void Display(int value) 
        {
            _point += value;
            _text.text = $"Your score {_point}";
        }

    }

}
