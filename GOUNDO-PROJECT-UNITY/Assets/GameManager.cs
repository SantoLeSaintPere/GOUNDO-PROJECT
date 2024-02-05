using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    MyPlayerInputs inputActions;
    public GameObject winPanel, losePanel;
    public float timeToReload;

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

    public void QuitApplication()
    {
        Application.Quit();
    }
}
