using UnityEngine;

public class iBusSystem : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip[] announcements;

    private int currentStop = 0;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            PlayAnnouncement();
        }
    }

    void PlayAnnouncement()
    {
        if (currentStop < announcements.Length)
        {
            audioSource.clip = announcements[currentStop];
            audioSource.Play();
            currentStop++;
        }
    }
}
