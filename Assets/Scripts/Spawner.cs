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
            _spawnPoints[i].SpawnEnemy();
        }
    }
}
