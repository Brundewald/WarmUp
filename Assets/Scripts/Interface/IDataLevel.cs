using UnityEngine;

namespace WarmUp
{
    public interface IDataLevel
    {
        float PlatformQuantity { get; }
        float PlatformOffsetX { get; }
        Vector3 StartPlatformPosition { get; }
        Vector3 FinishPlatformPosition { get; }
        Vector3 PlatformScale { get; }
    }
}
