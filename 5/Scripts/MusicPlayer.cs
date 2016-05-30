using UnityEngine;
using System.Collections;

public class MusicPlayer : MonoBehaviour
{
    public GameObject mus;
    public AudioClip[] clips;
    private AudioSource audioSource;

    // Use this for initialization
    void Start()
    {
        mus = GameObject.FindGameObjectWithTag("Item");
        audioSource = mus.GetComponent<AudioSource>();
        audioSource.loop = false;
    }

    private AudioClip GetRandomClip()
    {
        return clips[Random.Range(0, clips.Length)];
    }
    // Update is called once per frame
    void Update()
    {
        if (!audioSource.isPlaying)
        {
            audioSource.clip = GetRandomClip();
            audioSource.Play();
        }
    }
}
