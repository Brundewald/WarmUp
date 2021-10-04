using UnityEngine;

namespace WarmUp
{
    public sealed class SetPlatformPosition : ISetPlatformPosition
    {
        private readonly LevelData _levelData;
        private readonly IPlatformBuilder _PlatformBuilder;
        private Vector3 _offset;
        private Vector3 _wayPlatformPosition;

        public SetPlatformPosition(LevelData levelData, IPlatformBuilder platformBuilder)
        {
            _levelData = levelData;
            _PlatformBuilder = platformBuilder;
        }

        public void SetPlatformsPositions()
        {
            SetStartAndFinishPositions();
            SetWayPlatformsPositions();
        }

        private void SetStartAndFinishPositions() 
        {
            _PlatformBuilder.StartPlatform.position = _levelData.StartPlatformPosition;
            _PlatformBuilder.FinishPlatform.position = _levelData.FinishPlatformPosition;
            
        }

        private void SetWayPlatformsPositions() 
        {
            foreach (var wayPlatform in _PlatformBuilder.AllWayPlatforms)
            {
                wayPlatform.position = RandomWayPlatformPosition();
            }
        }

        private Vector3 RandomWayPlatformPosition() 
        {
            _offset = new Vector3(_levelData.PlatformOffsetX, Random.Range(2f, -2f), 0);
            if (_wayPlatformPosition == null) _wayPlatformPosition = _levelData.StartPlatformPosition + _offset;
            else  _wayPlatformPosition = _wayPlatformPosition + _offset;
            return _wayPlatformPosition;
        }
    }
}
