using UnityEngine;

public class WeaponManager : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public GameObject Weapon;

    public void EndbleWeaponCollider(int isEnable)
    {
        if (Weapon != null)
        {
            Collider col = Weapon.GetComponent<Collider>();
            if(col = null)
            {
                if (isEnable == 1)
                    col.enabled = true;
                else
                    col.enabled = false;
            }
        }
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
