using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForwardMovement : MonoBehaviour
{
    [SerializeField] private float _speed;

    private void Update()
    {
        transform.localPosition += Vector3.forward * _speed * Time.deltaTime;
    }
}
