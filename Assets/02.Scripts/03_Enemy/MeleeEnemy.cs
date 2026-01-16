using UnityEngine;

public class MeleeEnemy : EnemyBase
{
    [SerializeField] private Transform target;
    private void Start()
    {
        if(target==null)
        {
            target=GameObject.FindGameObjectWithTag("Player").transform;
        }
    }
    private void Update()
    {
        if (!isDead&&target!=null)
        {
            Move();
        }
        
    }
    protected override void Move()
    {
        Vector3 dir=(target.position - transform.position).normalized;
        //dir.y=0;
        transform.position+=dir*enemyData.moveSpeed*Time.deltaTime;


        //transform.Translate(Vector3.back*enemyData.moveSpeed*Time.deltaTime);
        
        //transform.Translate(Vector3.forward*enemyData.moveSpeed*Time.deltaTime);
        //throw new System.NotImplementedException();
    }

    protected override void Attack()
    {
        if (target != null)
        {
            PlayerController player = target.GetComponent<PlayerController>();
            if(player != null)
            {
                player.TakeDamage(enemyData.attackDamage);
            }
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Attack();
            Die();
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Attack();
            Die();
        }
    }
}
