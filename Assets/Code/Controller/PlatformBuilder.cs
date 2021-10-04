using System.Collections.Generic;
using UnityEngine;

namespace WarmUp
{
    public class PlatformBuilder: IPlatformBuilder
    {
        private readonly LevelData _levelData;
        private Transform _startPlatform;
        private Transform _finishPlatform;
        private Transform _wayPlatform;
        private List<Transform> _allWayPlatforms;

        public PlatformBuilder(LevelData levelData) 
        {
            _levelData = levelData;
        }

        public void BuildPlatforms() 
        {
            BuildStartPlatform();
            BuildFinishPlatform();
            BuildAllWayPlatforms();
        }

        private Transform BuildStartPlatform() 
        {
            GameObject start = GameObject.CreatePrimitive(PrimitiveType.Cube);
            start.GetComponent<Transform>().localScale = _levelData.PlatformScale;
            start.GetComponent<MeshRenderer>().material = _levelData.StartMaterial;
            start.name = _levelData.Start;
            _startPlatform = start.transform;
            return _startPlatform;
        }

        private Transform BuildFinishPlatform()
        {
            GameObject finish = GameObject.CreatePrimitive(PrimitiveType.Cube);
            finish.GetComponent<Transform>().localScale = _levelData.PlatformScale;
            finish.GetComponent<MeshRenderer>().material = _levelData.FinishMaterial;
            finish.name = _levelData.Finish;
            _finishPlatform = finish.transform;
            return _finishPlatform;
        }

        private List<Transform> BuildAllWayPlatforms() 
        {
            _allWayPlatforms = new List<Transform>();

            for (int index = 0; index < _levelData.PlatformQuantity; index++) 
            {
                if (_wayPlatform == null) BuildWayPlatform();
                else
                {
                    _allWayPlatforms.Add(_wayPlatform);
                    BuildWayPlatform();
                }
            }
            return _allWayPlatforms;
        }
        private Transform BuildWayPlatform ()
        {
            GameObject wayPlatform = GameObject.CreatePrimitive(PrimitiveType.Cube);
            wayPlatform.GetComponent<Transform>().localScale = _levelData.PlatformScale;
            wayPlatform.GetComponent<MeshRenderer>().material = _levelData.WayPlatformMaterial;
            _wayPlatform = wayPlatform.transform;
            return _wayPlatform;
        }

        public Transform StartPlatform => _startPlatform;
        public Transform FinishPlatform => _finishPlatform;
        public List<Transform> AllWayPlatforms => _allWayPlatforms;
    }
}
