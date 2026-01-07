using UnityEngine;

public abstract class WeaponBase : MonoBehaviour
{
    //여기서 무기베이스 만들고 상속받기

    //so연결하기
    [Header("Weapon Data")]
    [SerializeField]protected WeaponData weaponData;

    protected float lastFireTime;

    //무기들의 공격방식 override하기
    public abstract void Attack();

    public void Initalize(WeaponData data)
    {
        weaponData = data;
    }

    protected bool CanAttack()
    {
        return Time.time >= lastFireTime + 1f / weaponData.fireRate;
    }

    public virtual void Equip()
    {
        gameObject.SetActive(true);
        Debug.Log("Weapon Equipped: " + weaponData.weaponName);
    }
}
