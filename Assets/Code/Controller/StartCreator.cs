using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace WarmUp
{
    public class StartCreator : ILevelFactory
    {
        private string _startName;
        
        public StartCreator(string startName)
        {
            _startName = startName;
        }

        public Transform LevelBuilder()
        {
            GameObject start = new GameObject(_startName);
            start.AddComponent<BoxCollider>();
            start.AddComponent<MeshFilter>();
            start.AddComponent<MeshRenderer>().material.color = Color.green;
            return start.transform;
        }

    }
}
