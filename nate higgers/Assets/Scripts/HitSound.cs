using UnityEngine;

public class HitSound : MonoBehaviour
{
    public AudioClip hitSound; // <-- This MUST be AudioClip

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Enemy") && collision.gameObject.name == "SpecialEnemy")
        {
            AudioSource.PlayClipAtPoint(hitSound, collision.transform.position);
        }
    }
}