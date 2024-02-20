using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    public Image healthBar;

    public float health;
    public float maxHealth;

    GameManager gameManager;
    bool checkHealth;
    // Start is called before the first frame update
    void Start()
    {
        gameManager = FindObjectOfType<GameManager>();
        health = maxHealth;   
    }

    // Update is called once per frame
    void Update()
    {
        healthBar.fillAmount = health/maxHealth;

        Invoke("CheckHealth", 2);

        if(health <=0)
        {
            health = 0;
            gameManager.Lose();
        }
    }

    void CheckHealth()
    {
        health -= Time.deltaTime;
    }
}
