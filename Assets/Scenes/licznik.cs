using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    public int coins = 0;

    private void Awake()
    {
        instance = this;
    }

    public void AddCoins(int amount)
    {
        coins += amount;
        Debug.Log("Monetki " + coins);
        if (coins < 4)
        {
            SceneManager.LoadScene("EndGame");
        }
    }

     
}