using UnityEngine;

public class EnemyDemage : MonoBehaviour
{

    public PlayerHealth playerHealth;
    public int demage = 2;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
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
