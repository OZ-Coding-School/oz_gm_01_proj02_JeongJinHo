using UnityEngine;

public class WeaponManager : MonoBehaviour
{
    [Header("Mount Points")]
    [SerializeField] private Transform mgMountPos;
    [SerializeField] private Transform msMountPos;
    [SerializeField] private Transform grMountPos;

    private WeaponBase weaponBase;
    private GameObject weaponMG;
    private GameObject weaponMS;
    private GameObject weaponGR;

    public void EquipMG(WeaponData data)
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
    public void EquipMS(WeaponData data)
    {
        weaponMS = Instantiate(data.weaponPrefab, msMountPos.position, msMountPos.rotation);       
        weaponMS.transform.SetParent(msMountPos, true);

        weaponMS.transform.localPosition = Vector3.zero;
        weaponMS.transform.localRotation = data.weaponPrefab.transform.localRotation;

        weaponBase = weaponMS.GetComponent<WeaponBase>();

        if (weaponBase != null)
        {
            weaponBase.Initalize(data);
        }
    }
    public void EquipGR(WeaponData data)
    {
        weaponGR = Instantiate(data.weaponPrefab, grMountPos.position, grMountPos.rotation);
        weaponGR.transform.SetParent(grMountPos, true);
        weaponGR.transform.localPosition = Vector3.zero;
        weaponGR.transform.localRotation = Quaternion.identity;
        weaponBase = weaponGR.GetComponent<WeaponBase>();
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
