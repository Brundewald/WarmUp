using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace WarmUp
{
    public interface IPlayerFactory 
    {
        Transform CreatePlayer();
    }

}
