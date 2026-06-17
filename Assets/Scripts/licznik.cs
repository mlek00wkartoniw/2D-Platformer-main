using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    public int coins = 0;

    public TMP_Text coinsText;

    private void Awake()
    {
        instance = this;
    }

    private void Start()
    {
        UpdateCoinsUI();
    }

    public void AddCoins(int amount)
    {
        coins += amount;

        UpdateCoinsUI();

        Debug.Log("Monetki " + coins);

        if (coins > 8)
        {
            SceneManager.LoadScene("EndGame");
        }
    }

    void UpdateCoinsUI()
    {
        coinsText.text = "Monety: " + coins;
    }
}