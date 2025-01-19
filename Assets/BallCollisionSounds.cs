using UnityEngine;

public class BallCollisionSounds : MonoBehaviour
{
    private AudioSource audioSource;

    // Audio clips for different collision events
    public AudioClip computerPaddleHitSound;  // Assign in Inspector
    public AudioClip playerPaddleHitSound;    // Assign in Inspector
    public AudioClip topWallHitSound;         // Assign in Inspector
    public AudioClip bottomWallHitSound;      // Assign in Inspector

    void Start()
    {
        // Get the AudioSource component on the Ball
        audioSource = GetComponent<AudioSource>();
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        // Check if the collision is with the Computer Paddle
        if (collision.gameObject.CompareTag("ComputerPaddle"))
        {
            audioSource.PlayOneShot(computerPaddleHitSound);
        }
        // Check if the collision is with the Player Paddle
        else if (collision.gameObject.CompareTag("PlayerPaddle"))
        {
            audioSource.PlayOneShot(playerPaddleHitSound);
        }
        // Check if the collision is with the Top Wall
        else if (collision.gameObject.CompareTag("TopWall"))
        {
            audioSource.PlayOneShot(topWallHitSound);
        }
        // Check if the collision is with the Bottom Wall
        else if (collision.gameObject.CompareTag("BottomWall"))
        {
            audioSource.PlayOneShot(bottomWallHitSound);
        }
    }
}

