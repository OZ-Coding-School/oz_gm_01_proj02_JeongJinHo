using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "EnemyData", menuName = "EnemyData/EnemyDataSO")]
public class EnemyDataSO : ScriptableObject
{
    [SerializeField] public string enemyName;
    [SerializeField] public GameObject enemyPrefab;
    [SerializeField] public float moveSpeed;
    [SerializeField] public int maxHealth;
    [SerializeField] public float attackDamage;


}
