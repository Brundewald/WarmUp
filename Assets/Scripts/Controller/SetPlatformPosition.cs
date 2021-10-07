using UnityEngine;

namespace WarmUp
{
    public sealed class SetPlatformPosition : ISetPlatformPosition
    {
        private readonly LevelData _levelData;
        private readonly IPlatformBuilder _platformBuilder;
        private readonly float _scale;
        private readonly float _quantity;
        private readonly float _offsetX;
        private Vector3 _offset;
        private Vector3 _wayPlatformPosition;

        public SetPlatformPosition(LevelData levelData, IPlatformBuilder platformBuilder)
        {
            _levelData = levelData;
            _platformBuilder = platformBuilder;
            _scale = _levelData.PlatformScale.x;
            _quantity = _levelData.PlatformQuantity;
            _offsetX = _levelData.PlatformOffsetX;
        }

        public void SetPlatformsPositions()
        {
            SetStartAndFinishPositions();
            SetWayPlatformsPositions();
        }

        private void SetStartAndFinishPositions() 
        {
            var finishPlatformOffset = (_scale + _offsetX/2) * _quantity ;
            var finishPaltformPosition = new Vector3 (_levelData.StartPlatformPosition.x + finishPlatformOffset, Random.Range(2f, -2f), 0);
            _platformBuilder.StartPlatform.position = _levelData.StartPlatformPosition;
            _platformBuilder.FinishPlatform.position = finishPaltformPosition;
        }

        private void SetWayPlatformsPositions() 
        {
            foreach (var wayPlatform in _platformBuilder.AllWayPlatforms)
            {
                wayPlatform.position = RandomWayPlatformPosition();
            }
        }

        private Vector3 RandomWayPlatformPosition()
        {
            _offset = new Vector3(_offsetX, Random.Range(2f, -2f), 0);
            _wayPlatformPosition = _wayPlatformPosition + _offset;
            return _wayPlatformPosition;
        }
    }
}
