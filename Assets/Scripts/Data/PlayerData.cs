using UnityEngine;

namespace WarmUp 
{
    [CreateAssetMenu(fileName ="PlayerData", menuName ="Data/PlayerData")]
    public sealed class PlayerData:ScriptableObject , IDataPlayer
    {
        [SerializeField] private string _playerName;
        [SerializeField] private float _playerSpeed;
        [SerializeField] private Vector3 _playerOffset = new Vector3(0, 3f,0);

        public string Name => _playerName;
        public float Speed => _playerSpeed;
        public Vector3 Offset => _playerOffset;
    }
}

