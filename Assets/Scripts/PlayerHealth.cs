using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    public int health;
    public int maxHealth = 10;

    public Image[] healthSegments; // 5 segmentów paska ¿ycia

    public Transform respawnPoint;

    void Start()
    {
        health = maxHealth;
        UpdateHealthBar();
    }

    public void TakeDemage(int amount)
    {
        health -= amount;

        if (health < 0)
            health = 0;

        UpdateHealthBar();

        if (health <= 0)
        {
            Respawn();
        }
    }

    public void Heal(int amount)
    {
        health += amount;

        if (health > maxHealth)
            health = maxHealth;

        UpdateHealthBar();
    }

    void Respawn()
    {
        transform.position = respawnPoint.position;
        health = maxHealth;
        UpdateHealthBar();
    }

    void UpdateHealthBar()
    {
        int activeSegments = health / 2;

        for (int i = 0; i < healthSegments.Length; i++)
        {
            healthSegments[i].enabled = i < activeSegments;
        }
    }
}