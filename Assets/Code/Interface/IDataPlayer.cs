using UnityEngine;

namespace WarmUp 
{
    public interface IDataPlayer
    {
        Vector3 Position { get; }
        float Speed { get; }
    }
}
