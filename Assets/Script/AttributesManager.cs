using Unity.Burst.Intrinsics;
using UnityEngine;


public class AttributesManager : MonoBehaviour
{
    public int health;
    public int attack;

    public float critDamage = 1.5f;
    public float critChance = 0.5f;
    public void TakeDamage(int amount)
    {
        health -= amount;

        if (health <= 0)
        {
            Debug.Log(gameObject.name + " is Dead");
        }
    }

    //TARGET DAMAGE
    public void DealDamage(GameObject target)
    {
        AttributesManager atm = target.GetComponent<AttributesManager>();

        if (atm == null) return;

        float totalDamage = attack;

        if (Random.Range(0f, 1f) < critChance)
        {
            totalDamage *= critDamage;

            Debug.Log("Critical Hit!");
        }

        atm.TakeDamage((int)totalDamage);
    }
}