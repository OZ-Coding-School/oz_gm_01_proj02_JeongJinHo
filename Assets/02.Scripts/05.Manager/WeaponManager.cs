using UnityEngine;

public class WeaponManager : MonoBehaviour
{
    [Header("Mount Points")]
    [SerializeField] private Transform mgMountPos;

    private WeaponBase weaponBase;
    private GameObject weaponMG;

    public void EquipWeapon(WeaponData data)
    {
        weaponMG = Instantiate(data.weaponPrefab, mgMountPos.position,mgMountPos.rotation);
        weaponMG.transform.SetParent(mgMountPos, true);

        weaponMG.transform.localPosition = Vector3.zero;
        weaponMG.transform.localRotation = Quaternion.identity;
        
        weaponBase =weaponMG.GetComponent<WeaponBase>();

        if (weaponBase != null)
        {
            weaponBase.Initalize(data);
        }
    }
    private void Update()
    {
        //if (Input.GetMouseButton(0))
        //{
        //    weaponBase.Attack();
        //}
    }

}
