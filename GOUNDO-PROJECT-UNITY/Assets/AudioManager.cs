using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    AudioSource audioSource;
    public AudioClip menuClip, gameClip;

    private void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }
    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        SwitchClip(menuClip);
    }

    public void SwitchClip(AudioClip clip)
    {
        audioSource.clip = clip;
        audioSource.Play();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
