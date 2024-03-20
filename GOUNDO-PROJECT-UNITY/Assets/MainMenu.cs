using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public TMP_Text txt;
    public float timer = 5;

    float newTimer;

    AudioManager audioManager;
    // Start is called before the first frame update
    void Start()
    {
        audioManager = FindObjectOfType<AudioManager>();
        Invoke("LoadNextScene", timer);

        newTimer = timer;
    }

    private void Update()
    {
        newTimer -= Time.deltaTime;
        UpdateTimer(newTimer);
    }

    public void LoadNextScene()
    {
        audioManager.SwitchClip(audioManager.gameClip);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex +1);
    }

    void UpdateTimer(float currentTime)
    {
        currentTime += 1;

        float seconds = Mathf.FloorToInt(currentTime % 60);
        txt.text = seconds.ToString();
    }
}
