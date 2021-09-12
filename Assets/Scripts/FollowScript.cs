using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowScript : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    private Transform _parentPos;
    private Vector3 _rotateVect = new Vector3(1, 1, 0);
    private float _followSpeed = 1;

    private void Start()
    {
        transform.position = _parentPos.position;
    }

    private void Update()
    {
        transform.position = _parentPos.position;
        transform.Rotate(_rotateVect);
    }

}
