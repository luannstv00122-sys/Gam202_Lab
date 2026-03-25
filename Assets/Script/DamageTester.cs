using UnityEngine;


public class DamageTester : MonoBehaviour
{
    public AttributesManager player;

    public AttributesManager enemy;


    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.O))
            player.DealDamage(enemy.gameObject);

        if (Input.GetKeyDown(KeyCode.P))
            enemy.DealDamage(player.gameObject);
    }
}

