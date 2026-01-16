using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour
{
    public WeaponData weaponData;
    public WeaponData weaponDataMS;
    public WeaponData weaponDataGR;

    public WeaponManager weaponManager;

    public void OnClick()
    {
        weaponManager.EquipMG(weaponData);
    }
    public void OnClickMS()
    {
        weaponManager.EquipMS(weaponData);
    }
    public void OnClickGR()
    {
        weaponManager.EquipGR(weaponData);
    }
}
