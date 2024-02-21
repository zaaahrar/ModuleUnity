using System.Collections;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private SpawnPoint[] _spawnPoints;
    [SerializeField] private int _cooldown;

    private float _time;

    private void Start()
    {
        Spawn();
    }

    private void Update()
    {
        _time += Time.deltaTime;

        if(_time >= _cooldown)
        {
            Spawn();
            _time = 0;
        }
    }

    private void Spawn()
    {
        for (int i = 0; i < _spawnPoints.Length; i++)
        {
            MovementToTarget enemy = Instantiate(_spawnPoints[i].Enemy, _spawnPoints[i].transform.position, Quaternion.identity);
            enemy.SetTarget(_spawnPoints[i].EnemyTarget);
        }
    }
}
