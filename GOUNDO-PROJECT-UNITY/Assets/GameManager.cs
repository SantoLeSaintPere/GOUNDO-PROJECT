using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    MyPlayerInputs inputActions;
    public GameObject winPanel, losePanel;
    public float timeToReload;

    bool cantLose;
    private void Awake()
    {
        inputActions = new MyPlayerInputs();
    }

    private void OnEnable()
    {
        inputActions.UI.Enable();
    }

    private void OnDisable()
    {
        inputActions.UI.Disable();
    }

    // Start is called before the first frame update
    void Start()
    {
        winPanel.SetActive(false);
        losePanel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(inputActions.UI.QUIT.WasPerformedThisFrame())
        {
            QuitApplication();
        }

        if (inputActions.UI.RELOAD.IsPressed())
        {
            Reload();
        }
    }

    public void Win()
    {
        cantLose = true;
        winPanel.SetActive(true);
        Invoke("LoadScene", timeToReload);
    }

    public void Lose()
    {
        if(!cantLose)
        {
            losePanel.SetActive(true);
            Invoke("Reload", timeToReload);
        }

    }

    public void LoadScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void Reload()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void QuitApplication()
    {
        Application.Quit();
    }
}
