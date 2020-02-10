using UnityEngine;

namespace DuckShoot
{
public class Target : MonoBehaviour
{
    public float health;

    public void TakeDamage (float amount)
    {
        health -= amount;
        if (health <= 0f)
        {
            KnockedOver();
        }
    }

    void KnockedOver()
    {
        Destroy(gameObject);
    }
}
}
