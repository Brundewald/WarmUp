using UnityEngine;

namespace WarmUp 
{
    public sealed class PlayerInitialization : IInitialize
    {
        private readonly IPlayerFactory _playerFactory;
        private Transform _player;

        public PlayerInitialization(IPlayerFactory playerFactory, Vector3 playerPosition, Vector3 offset) 
        {
            _playerFactory = playerFactory;
            _player = _playerFactory.CreatePlayer();
            _player.position = playerPosition+offset;
        }
        
        public void Initialize() 
        {
        }

        public Transform GetPlayer() 
        {
            return _player;
        }
    }
}
