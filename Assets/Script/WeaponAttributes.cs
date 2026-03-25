using UnityEngine;

public class WeaponAttributes : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public AttributesManager atm;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Enemy"))
        {
            atm.DealDamage(other.gameObject);
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
