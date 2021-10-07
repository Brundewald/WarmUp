using UnityEngine;

namespace WarmUp 
{
    [CreateAssetMenu(fileName = "Data", menuName = "Data/Data")]
    public sealed class Data : ScriptableObject
    {
        [SerializeField] private PlayerData _playerData;
        [SerializeField] private LevelData _levelData;
        public PlayerData Player => _playerData;
        public LevelData Level => _levelData;

    }

}
