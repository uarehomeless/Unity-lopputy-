using UnityEngine;

public class Respawn : MonoBehaviour
{
    public Transform spawnPoint;
    CharacterController controller;

    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("KillBlock"))
        {
            controller.enabled = false;      // IMPORTANT
            transform.position = spawnPoint.position;
            controller.enabled = true;
        }
    }
}