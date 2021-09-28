using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace WarmUp
{
    public sealed class LevelInitialization : IInitialization
    {
        private readonly ILevelFactory _levelFactory;
        private Transform _start;
        private Vector3 _startPosition;

        public LevelInitialization(ILevelFactory levelFactory)
        {
            _levelFactory = levelFactory;
            _start = _levelFactory.LevelBuilder();
            _start.position = _startPosition;
        }

        public void Initialization()
        {
        }
    }
}