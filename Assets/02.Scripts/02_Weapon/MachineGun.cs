using UnityEngine;

public class MachineGun : WeaponBase
{
    [SerializeField] private Transform firePoint;
    

    private void Update()
    {
        if (Input.GetMouseButton(0))
        {
            Attack();
        }
    }
    public override void Attack()
    {
        if(Time.time < lastFireTime + 1f/weaponData.fireRate)
        {
            return;
        }

        Ray ray=Camera.main.ScreenPointToRay(Input.mousePosition);
        Vector3 dir;
        if(Physics.Raycast(ray,out RaycastHit hit,100f))
        {
            dir=(hit.point-firePoint.position).normalized;
        }
        else
        {
            dir = ray.direction;
        }
        GameObject bulletObj=Instantiate(weaponData.projectilePrefab, firePoint.position, Quaternion.LookRotation(dir));
        Projectile projectile=bulletObj.GetComponent<Projectile>();
        if(projectile != null)
        {
            projectile.Setup(weaponData.attackSpeed, weaponData.damage, dir);
        }

        lastFireTime =Time.time;
    }
}
