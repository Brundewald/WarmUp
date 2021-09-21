using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace WarmUp 
{
    public class GameController : MonoBehaviour
    {
        private InteractiveObject[] _interactiveObjects;    
       
        
        private void Awake()
        {            
            _interactiveObjects = FindObjectsOfType<InteractiveObject>();
        }      

    }

}
