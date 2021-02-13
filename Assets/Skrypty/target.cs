
using UnityEngine;

public class target : MonoBehaviour
{
    public float zdrowie = 50f;
    public void TakeDamage (float amount)
    {
        zdrowie -=amount;
        if(zdrowie <=0f)
        {
            Die();
        }
    }

    void Die()
    {
        Destroy(gameObject);
    }
}
