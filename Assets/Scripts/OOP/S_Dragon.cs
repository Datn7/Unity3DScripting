using UnityEngine;

public class S_Dragon : S_Enemy
{
    
    public bool isAttacking = false;

    private void Update()
    {
        if (isAttacking)
        {
            base.Attack();
        }
    }

    void Attack()
    {
        print("Enemy attacks for " + damage + " damage!");
    }
}
