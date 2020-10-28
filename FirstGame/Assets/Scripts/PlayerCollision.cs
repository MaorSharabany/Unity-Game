using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public PlayerMovment movment;  // A reference to our PlayerMovment script

    // This function runs when we hit another objet.
    // We get information about the collisions and call it "collisionInfo".
    void OnCollisionEnter(Collision collisionInfo)
    {
        // We check if the object we collided with has a tag called "Obstacle".
        if(collisionInfo.collider.tag == "Obstacle")
        {
            movment.enabled = false; // Disable the players movment.
            FindObjectOfType<GameManager>().EndGame();

        }
    }
}
