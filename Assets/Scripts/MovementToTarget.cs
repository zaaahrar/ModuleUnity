using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class MovementToTarget : MonoBehaviour
{
    [SerializeField] private Transform _target;
    [SerializeField, Range(1, 10)] private float _speed;

    private readonly float DistanceToDeath = 0.5f;

    private void Update()
    {
        if (Vector3.Distance(transform.position, _target.position) < DistanceToDeath)
            Destroy(gameObject);

        transform.position = Vector3.MoveTowards(transform.position, _target.position, _speed * Time.deltaTime);
    }

    public void SetTarget(Transform target)
    {
        _target = target;
    }
}
