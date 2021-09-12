using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControler : MonoBehaviour
{
    private const string Horizontal = nameof(Horizontal);
    private const string Vertical = nameof(Vertical);
    private float _speed = 1;
    private Vector3 _forward = new Vector3 (1, 0, 0);

    
    // Update is called once per frame
    private void Update()
    {
      
        transform.Translate(Vector3.right * Input.GetAxis(Horizontal) * _speed * Time.deltaTime);
        transform.Translate(Vector3.up * Input.GetAxis(Vertical) * _speed * Time.deltaTime);


    }
}
