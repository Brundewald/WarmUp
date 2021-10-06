using System.Collections.Generic;
using UnityEngine;

namespace WarmUp
{
    public interface IPlatformBuilder
    {
        void BuildPlatforms();
        Transform StartPlatform { get; }
        Transform FinishPlatform { get; }
        List<Transform> AllWayPlatforms { get; }
    }
}
