using UnityEngine;

public class SpawnPoint : MonoBehaviour
{
    [SerializeField] private MovementToTarget _enemy;
    [SerializeField] private Transform _enemyTarget;

    public void SpawnEnemy()
    {
        MovementToTarget enemy = Instantiate(_enemy, transform.position, Quaternion.identity);
        enemy.SetTarget(_enemyTarget);
    }
}
