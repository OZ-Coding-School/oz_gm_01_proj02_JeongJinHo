using UnityEngine;

public class Projectile : MonoBehaviour
{
    private float damage;
    private Rigidbody rb;

    //private void Awake()
    //{
    //    rb=GetComponent<Rigidbody>();
    //}
    public void Setup(float speed,float damage,Vector3 dir)
    {
        this.damage = damage;
        
        rb= GetComponent<Rigidbody>();

        transform.forward = dir;
        
        rb.velocity = dir * speed;

        Destroy(gameObject, 5f); // 5초 후에 파괴
    }

    //private void OnTriggerEnter(Collider other)
    //{
    //    if(other.CompareTag("Enemy"))
    //    {
    //        Debug.Log($"Hit Enemy for {damage} damage!");
    //        Destroy(gameObject); // 충돌 후 파괴
    //    }
    //}
}
