using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace WarmUp 
{
    public sealed class PlayerInitialization : IInitialization
    {
        private readonly IPlayerFactory _playerFactory;
        private Transform _player;
        [SerializeField]
        private Vector3 _playerPosition;

        public PlayerInitialization(IPlayerFactory playerFactory)
        {
            _playerFactory = playerFactory;
            _player = _playerFactory.CreatePlayer();
            _player.position = _playerPosition;
        }

        public void Initialization()
        {
        }

        public Transform GetPlayer()
        {
            return _player;
        }
    }

}
