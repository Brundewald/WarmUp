using UnityEngine;

namespace WarmUp
{
    public class PlayerFactory : IPlayerFactory
    {
        private readonly PlayerData _playerData;
        private Transform _player;

        public PlayerFactory(PlayerData playerData) 
        {
            _playerData = playerData;
        }

        public Transform CreatePlayer()
        {    
            var player = GameObject.CreatePrimitive(PrimitiveType.Sphere);
            player.AddComponent<Rigidbody>();
            player.AddComponent<PlayerView>();
            player.name = _playerData.Name;
            var rigidbody = player.GetComponent<Rigidbody>();
            rigidbody.freezeRotation = true;           
            _player = player.transform;
            return _player;
        }


    }
}
