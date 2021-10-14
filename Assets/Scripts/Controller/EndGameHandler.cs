using Controller;
using UnityEngine;

namespace WarmUp 
{
    public class EndGameLogic : ILateExecute
    {
        private readonly PlayerView _playerView;
        private readonly DisplayEndGame _displayEndGame;
        private bool _isDisplayOn = false;

        public EndGameLogic(DisplayEndGame displayEndGame)
        {
            _displayEndGame = displayEndGame;
            _playerView = Object.FindObjectOfType<PlayerView>();
        }

        public void LateExecute(float deltaTime)
        {
            if (_playerView.IsFinished && !_isDisplayOn)
            {
                _displayEndGame.ShowEndGameDisplay();
                _isDisplayOn = true;
            }
        }
       
    }

}
