using UnityEngine;

public class CHardMobDamage : MonoBehaviour
{
    public Transform hitBox;
    public float attackRange = 0.5f;
    public LayerMask enemyLayers;

    public int attackDamage = 40;
    public float attackRate = 2f;
    public float nextAttackTime = 0f;

    public Animator anim;


    private void Start()
    {
        anim = GetComponent<Animator>();
    }


    void Update()
    {
        if (Time.time >= nextAttackTime)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                Attack();
                nextAttackTime = Time.time + 1f / attackRate;
            }
        }
    }

    void Attack()
    {
        anim.SetTrigger("AttackL");
        Collider2D[] hitEnemies = Physics2D.OverlapCircleAll(hitBox.position, attackRange, enemyLayers);
        foreach (Collider2D Enemy in hitEnemies)
        {
            Enemy.GetComponent<EnemyHealthHard>().TakeDamage(attackDamage);
        }

    }

    void OnDrawGizmosSelected()
    {
        if (hitBox == null)
            return;

        Gizmos.DrawWireSphere(hitBox.position, attackRange);
    }
}
