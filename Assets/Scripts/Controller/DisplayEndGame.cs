using UnityEngine;
using WarmUp;

namespace Controller
{
    public sealed class DisplayEndGame : IInitialize
    {
        private GameObject _endGameDisplay;
        private const string _endGameDisplayPath = "UI/EndGameDisplay";

        public DisplayEndGame()
        {
            _endGameDisplay = Resources.Load<GameObject>(_endGameDisplayPath);
        }

        public void ShowEndGameDisplay()
        {
            if (_endGameDisplay is null)
                Debug.LogError("There is no object!");
            else
                Object.Instantiate(_endGameDisplay);
        }

        public void Initialize()
        {
        }
    }
}
