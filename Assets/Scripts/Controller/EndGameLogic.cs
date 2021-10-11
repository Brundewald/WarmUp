using UnityEditor.Experimental.TerrainAPI;
using UnityEngine;

namespace WarmUp 
{
    public sealed class EndGameLogic : ILateExecute
    {
        private readonly PlayerView _player;
        private GameObject _endGameDisplay;

        public EndGameLogic()
        {
            _player = GameObject.FindObjectOfType<PlayerView>();
            _endGameDisplay = Resources.Load<GameObject>("Prefabs/EndGameScreen");
        }

        public void LateExecute(float deltaTime)
        {
            FinishTrigger();
        }

        private void FinishTrigger()
        {
            if (_player.OnFinishPlatform)
            {
                var endGameScreen = Object.Instantiate(_endGameDisplay);
            }
        }

        
    }

}
