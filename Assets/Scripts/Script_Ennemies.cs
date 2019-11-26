    using UnityEngine;

public class Script_Ennemies : MonoBehaviour
{

    public float health = 50f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void TakeDamage (float amount)
    {
        health -= amount;
        if (health <=0)
        {
            Die();
        }
    }

    void Die()
    {
        Destroy(gameObject);
    }
}
