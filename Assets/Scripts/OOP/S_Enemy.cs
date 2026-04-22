using UnityEngine;

public class S_Enemy : MonoBehaviour
{
    public int health;
    public int damage;
    public int maxHealth;
    public int minHealth;
    public int maxDamage;
    public int minDamage;


    public void Attack()
    {
        damage = Random.Range(minDamage, maxDamage);
        GetComponent<Renderer>().material.color = Color.red;
        Debug.Log("Enemy attacks for " + damage + " damage!");
    }

   
}
