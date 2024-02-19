using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateAroundY : MonoBehaviour
{
    [SerializeField] private float _speed;

    private void Update()
    {
        transform.localEulerAngles += Vector3.up * _speed;
    }
}
