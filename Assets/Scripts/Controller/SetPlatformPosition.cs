using UnityEngine;

namespace WarmUp
{
    public sealed class SetPlatformPosition : ISetPlatformPosition
    {
        private readonly LevelData _levelData;
        private readonly IPlatformBuilder _PlatformBuilder;
        private float _scale;
        private float _quantity;
        private float _offsetX;
        private Vector3 _offset;
        private Vector3 _wayPlatformPosition;

        public SetPlatformPosition(LevelData levelData, IPlatformBuilder platformBuilder)
        {
            _levelData = levelData;
            _PlatformBuilder = platformBuilder;
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
            float finishPlatformOffset = (_scale + _offsetX/2) * _quantity ;
            Vector3 finishPaltformPosition = new Vector3 (_levelData.StartPlatformPosition.x + finishPlatformOffset, Random.Range(2f, -2f), 0);
            _PlatformBuilder.StartPlatform.position = _levelData.StartPlatformPosition;
            _PlatformBuilder.FinishPlatform.position = finishPaltformPosition;
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
            _offset = new Vector3(_offsetX, Random.Range(2f, -2f), 0);
            if (_wayPlatformPosition == null) 
                _wayPlatformPosition = _levelData.StartPlatformPosition + _offset;
            else  
                _wayPlatformPosition = _wayPlatformPosition + _offset;
            return _wayPlatformPosition;
        }
    }
}
