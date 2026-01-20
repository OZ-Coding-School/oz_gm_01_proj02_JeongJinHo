using UnityEngine;

public class RangeEnemy : EnemyBase
{
    [SerializeField] private GameObject projectilePrefab;
    [SerializeField] private Transform target;
    [SerializeField] private Transform firePoint;
    [SerializeField] private float fireRate = 3f;
    [SerializeField] private float moveTime = 5f;
    private Rigidbody rb;
    private void Start()
    {
        rb = GetComponent<Rigidbody>();

        if (target == null)
        {
            target = GameObject.FindGameObjectWithTag("Player").transform;
        }
    }
    protected override void Attack()
    {
        GameObject bullet = Instantiate(projectilePrefab, firePoint.position, firePoint.rotation);

        rb.velocity = firePoint.forward * 5f;
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Attack();
            Die();
        }
    }
    protected override void Move()
    {
        transform.Translate(Vector3.back * moveTime * Time.deltaTime);
        throw new System.NotImplementedException();
    }

    
}
