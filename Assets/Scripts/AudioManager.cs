using UnityEngine;

public class AudioManager : MonoBehaviour
{
    private AudioSource Source;
    private bool CanPlay = true;

    private void Awake()
    {
        Source = GetComponent<AudioSource>();
    }

    public void activeSound(bool x)
    {
        CanPlay = x;
    }

    public void play(AudioClip clip)
    {
        if(CanPlay)
            Source.PlayOneShot(clip);
    }
}