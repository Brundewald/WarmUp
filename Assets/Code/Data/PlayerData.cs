using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace WarmUp
{
    public class PlayerData : ScriptableObject
    {
        private string _playerName = "Player";
        private float _speed = 5.0f;
        private Vector3 _playerStartPosition = new Vector3(0f, 3f, 0f);

        public string PlayerName => _playerName;
        public float Speed => _speed;
        public Vector3 PlayerStartPosition => _playerStartPosition;
        
    }
}
