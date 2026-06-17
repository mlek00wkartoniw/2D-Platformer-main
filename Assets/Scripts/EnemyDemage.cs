using UnityEngine;

public class EnemyDemage : MonoBehaviour
{

    public PlayerHealth playerHealth;
    public int demage = 2;
    void Start()
    {
        
    }

    void Update()
    {
        
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            playerHealth.TakeDemage(demage);
        }
    }
}
