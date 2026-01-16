using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour
{
    public WeaponData weaponData;
    public WeaponManager weaponManager;

    public void OnClick()
    {
        weaponManager.EquipWeapon(weaponData);
    }
}
