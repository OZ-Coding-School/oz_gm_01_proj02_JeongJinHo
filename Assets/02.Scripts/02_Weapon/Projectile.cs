using UnityEngine;

public class Projectile : MonoBehaviour
{
    //[SerializeField]private WeaponData weaponData;

    private float damage;
    private Rigidbody rb;



    public void Setup(float speed,float damage,Vector3 dir)
    {
        this.damage = damage;
        
        rb= GetComponent<Rigidbody>();

        transform.forward = dir;
        
        rb.velocity = dir * speed;

        Destroy(gameObject, 5f); // 5ÃÊ ÈÄ¿¡ ÆÄ±«
    }

    private void OnTriggerEnter(Collider other)
    {
        EnemyBase enemy=other.GetComponent<EnemyBase>();

        if(enemy != null)
        {
            enemy.TakeDamage(this.damage);
            Destroy(gameObject);
            Debug.Log("Projectile hit enemy for " + damage + " damage.");
        }
    }
}
