using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName ="WeaponData", menuName = "WeaponData/Weapon/WeaponDataSO")]
public class WeaponData : ScriptableObject
{    
    
    [SerializeField] public string weaponName;
    [SerializeField] public GameObject weaponPrefab;
    [SerializeField] public GameObject projectilePrefab;
    [SerializeField] public float fireRate;
    [SerializeField] public float attackSpeed;
    [SerializeField] public int damage;



}
