using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{

    public int health;
    public int maxHealth = 10; 

    public Image healthBar;
    public Transform respawnPoint;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        health = maxHealth;
        UpdateHealthBar();
    }

    // Update is called once per frame
public void TakeDemage(int amount)
    {
        health -= amount; 
        if(health <=0)
        {
            Respawn();
        }
    }

public void Heal(int amount)
    {
        health += amount;
    }


    void Respawn()
    {
        transform.position = respawnPoint.position;
        health = maxHealth;
        UpdateHealthBar();
    }
    void UpdateHealthBar()
    {
        healthBar.fillAmount = (float)health/ maxHealth; 
    }



}
