using System.Collections.Generic;
using UnityEngine;

namespace WarmUp
{
    public sealed class LevelBuilder: ILevelBuilder
    {
        private readonly IPlatformBuilder _platformBuilder;
        private readonly ISetPlatformPosition _setPlatformPosition;

        public LevelBuilder(IPlatformBuilder platformBuilder, ISetPlatformPosition setPlatformPosition) 
        {
            _platformBuilder = platformBuilder;
            _setPlatformPosition = setPlatformPosition;
            
        }
        public void BuildLevel() 
        {
            _platformBuilder.BuildPlatforms();
            _setPlatformPosition.SetPlatformsPositions();
        }
    }
}
