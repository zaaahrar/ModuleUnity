using UnityEngine;

public class MovementToPoint : MonoBehaviour
{
    [SerializeField] private Transform[] _points;
    [SerializeField, Range(1, 10)] private float _speed;
    [SerializeField] private int _currentPointIndex;

    private void Awake()
    {
        _currentPointIndex = 0;
    }

    private void Update()
    {
        if (_currentPointIndex < _points.Length)
        {
            transform.position = Vector3.MoveTowards(transform.position, _points[_currentPointIndex].position, _speed * Time.deltaTime);

            if (Vector3.Distance(transform.position, _points[_currentPointIndex].position) < 0.1f)
            {
                _currentPointIndex++;
            }
        }
        else
        {
            _currentPointIndex = 0;
        }
    }
}
