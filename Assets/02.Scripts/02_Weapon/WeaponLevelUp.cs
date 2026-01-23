using UnityEngine;

public class WeaponLevelUp : MonoBehaviour
{
    [Header("SO연결")]
    [SerializeField] private WeaponData weaponData;

    [Header("무기 레벨업 정보")]
    [SerializeField] private int upgradeLevel = 0;
    [SerializeField] private float upgradeDamage = 5f;
    private int upgradeCost = 10;


    //private float CurrentDamage => weaponData.damage + (upgradeLevel * upgradeDamage);
    public float CurrentDamage()
    {
        return weaponData.damage + (upgradeLevel * upgradeDamage);
    }

    
    public void UpgradeWeapon()
    {
        if (GoldManager.instance.currentGold >= upgradeCost)
        {
            GoldManager.instance.SpendGold(upgradeCost);

            upgradeLevel++;
            Debug.Log($"무기 레벨업! 현재 레벨: {upgradeLevel}, 현재 데미지: {CurrentDamage()}");
        }
        else
        {

            Debug.Log($"골드가 부족합니다.{upgradeCost}만큼 필요");
        }
    }


}
