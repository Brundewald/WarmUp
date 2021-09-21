using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace WarmUp 
{
    public interface IEquatable<T>
    {
        bool Equals(T other);
    }

}
