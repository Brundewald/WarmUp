using System.Collections.Generic;
using UnityEngine;

namespace WarmUp 
{
    public sealed class LevelInitialization : IInitialize
    {
        private readonly ILevelBuilder _levelBuilder;
        private Transform _start;
        private Transform _finish;
        private Transform _wayPlafotm1;
        private Transform _wayPlafotm2;
        private Transform _wayPlafotm3;

        public LevelInitialization(ILevelBuilder levelBuilder) 
        {
            _levelBuilder = levelBuilder;
            _levelBuilder.BuildLevel();
            //_start = _levelBuilder.BuildStartPlatform();
            //_finish = _levelBuilder.BuildFinishPlatform();
            //_wayPlafotm1 = _levelBuilder.BuildWayPlatform();
            //_wayPlafotm2 = _levelBuilder.BuildWayPlatform();
            //_wayPlafotm3 = _levelBuilder.BuildWayPlatform();
            ////_start.position = startPosition;
            ////_finish.position = finishPosition;
            ////_wayPlafotm1.position = platformOffset;
            ////Debug.LogWarning(_wayPlafotm1.position);
            ////_wayPlafotm2.position = _wayPlafotm1.position + platformOffset;
            ////_wayPlafotm3.position = _wayPlafotm2.position + platformOffset;
        }

        public void Initialize()
        {
        }
    }

}
