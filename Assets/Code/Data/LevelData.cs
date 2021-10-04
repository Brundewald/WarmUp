using UnityEngine;

namespace WarmUp
{
    [CreateAssetMenu(fileName = "LevelData", menuName = "Data/LevelData")]
    public sealed class LevelData : ScriptableObject, IDataLevel
    {
        private string _start = "Start";
        private string _finish = "Finish";
        [SerializeField] private float _platformQuantity;
        [SerializeField] private float _platformOffsetX;
        [SerializeField] private Vector3 _startPlatformPosition;
        [SerializeField] private Vector3 _finishPlatformPosition;
        [SerializeField] private Vector3 _platformScale;      
        [SerializeField] private Material _startMaterial;
        [SerializeField] private Material _finishMaterial;
        [SerializeField] private Material _wayPlatformMaterial;
        public string Start => _start;
        public string Finish => _finish;
        public float PlatformQuantity => _platformQuantity;
        public float PlatformOffsetX => _platformOffsetX;
        public Vector3 StartPlatformPosition => _startPlatformPosition;
        public Vector3 FinishPlatformPosition => _finishPlatformPosition;
        public Vector3 PlatformScale => _platformScale;
        public Material StartMaterial => _startMaterial;
        public Material FinishMaterial => _finishMaterial;
        public Material WayPlatformMaterial => _wayPlatformMaterial;
    }
}