using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace WarmUp 
{
    public class PlayerFactory : IPlayerFactory
    {
        private readonly string _playerName;
        
        public PlayerFactory(string playerName) 
        {
            _playerName = playerName;
        }

        public Transform CreatePlayer() 
        {
            GameObject player = new GameObject(_playerName);            
            player.AddComponent<SphereCollider>();
            player.AddComponent<Rigidbody>();
            //player.AddComponent<MeshFilter>().mesh = Sphere.mesh;
            player.AddComponent<MeshRenderer>().material.color = Color.red;
            return player.transform;              
        }
    }

}
