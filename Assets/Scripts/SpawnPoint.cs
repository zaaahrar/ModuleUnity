using UnityEngine;

public class SpawnPoint : MonoBehaviour
{
    [SerializeField] private MovementToTarget _enemy;
    [SerializeField] private Transform _enemyTarget;

    public Transform EnemyTarget => _enemyTarget;
    public MovementToTarget Enemy => _enemy;
}
