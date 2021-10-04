using UnityEngine;

namespace WarmUp 
{
    [CreateAssetMenu(fileName ="PlayerData", menuName ="Data/PlayerData")]
    public sealed class PlayerData:ScriptableObject , IDataPlayer
    {
        [SerializeField] private string _playerName;
        [SerializeField] private float _playerSpeed;
        [SerializeField] private Vector3 _playerStartPosition;

        public string Name => _playerName;
        public float Speed => _playerSpeed;
        public Vector3 Position => _playerStartPosition;
    }
}

