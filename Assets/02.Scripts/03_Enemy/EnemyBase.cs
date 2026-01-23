using UnityEngine;

public abstract class EnemyBase : MonoBehaviour
{
    [SerializeField] protected EnemyDataSO enemyData;
    protected float curHp;
    protected bool isDead;
    [SerializeField] protected int dropGold;

    protected virtual void Awake()
    {
        curHp = enemyData.maxHealth;
    }

    public virtual void TakeDamage(float damage)
    {
        if (isDead) return;
        curHp -= damage;
        Debug.Log($"{enemyData.enemyName} took {damage} damage. Current HP: {curHp}");
        if (curHp <= 0)
        {
            Die();
        }
    }
    
    protected virtual void Die()
    {
        isDead = true;
        
        // 추가적인 죽음 처리 로직 (예: 애니메이션 재생, 아이템 드롭 등)
        Destroy(gameObject);

        GoldManager.instance.AddGold(dropGold);
    }
    protected abstract void Move();
    protected abstract void Attack();


    
}
