using UnityEngine;

public class S_Dragon : S_Enemy
{
    
    public bool isAttacking = false;



    private void Start()
    {
        S_Dragon dragon = new S_Dragon();
        dragon.Attack();

        S_Dragon dragon2 = new BlueDragon();
        dragon.Attack();

        S_Dragon dragon3 = new RedDragon();
        dragon.Attack();
    }


    private void Update()
    {
        if (isAttacking)
        {
            base.Attack();
        }
    }

    public new virtual void Attack()
    {
        print("Enemy attacks for " + damage + " damage!");
    }
}

public class  BlueDragon : S_Dragon
{
    public override void Attack()
    {
        print("Blue Enemy attacks for " + damage + " damage!");
    }
}

public class RedDragon : S_Dragon
{
    public override void Attack()
    {
        print("Red Enemy attacks for " + damage + " damage!");
    }
}
