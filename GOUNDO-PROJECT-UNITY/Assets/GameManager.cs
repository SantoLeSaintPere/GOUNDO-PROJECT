using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject winPanel, losePanel;
    public float timeToReload;
    // Start is called before the first frame update
    void Start()
    {
        winPanel.SetActive(false);
        losePanel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Lose()
    {
        losePanel.SetActive(true);
        Invoke("Reload", timeToReload);

    }

    public void Reload()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
