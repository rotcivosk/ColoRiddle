using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    [SerializeField] private AudioClip ledSound;
    [SerializeField] private AudioClip switchSound;
    [SerializeField] private AudioSource audioSource;
    [SerializeField] private AudioClip exitSound;
    void OnCollisionEnter2D(Collision2D collision)
    {
        // Verifica a tag do objeto colidido
        if (collision.gameObject.CompareTag("LED"))
        {
            PlaySound(ledSound);
        }

    }

      void OnTriggerEnter2D(Collider2D other)
    {
        // Verifica a tag do objeto colidido
        if (other.CompareTag("Switch"))
        {
            // Toca o som específico para Switch
            PlaySound(switchSound);
        }
        else if (other.CompareTag("Exit"))
        {
            // Toca o som específico para Exit
            PlaySound(exitSound);
        }
    }

    private void PlaySound(AudioClip clip)
    {
        // Verifica se há um AudioSource e um AudioClip
        if (audioSource != null && clip != null)
        {
            audioSource.PlayOneShot(clip);
        }
    }
}