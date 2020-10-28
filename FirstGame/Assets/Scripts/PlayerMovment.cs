using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovment : MonoBehaviour
{
    // This is a reference to the RigidBody component called "rb
    public Rigidbody rb;

    public float ForwardForce = 2000f;
    public float SideWaysForce = 500f;
    public float UpwardForce = 100f;
    public float DownwardForce = 100f;
    public float restartDelay = 1f;

    /*   bool isPaused = false;

       public void pauseGame()
       {
           if (isPaused)
           {
               Time.timeScale = 1;
               isPaused = false;
           }
           else
           {
               Time.timeScale = 0;
               isPaused = true;
           }

       }*/

    // We marked this as "Fixed"Update because we are using it to mess with physics
    void FixedUpdate()
    {
        // Add a forward force
        rb.AddForce(0, 0, ForwardForce * Time.deltaTime);

        if (Input.GetKey("d"))
        {
            rb.AddForce(SideWaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (Input.GetKey("a"))
        {
            rb.AddForce(-SideWaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (Input.GetKey("w"))
        {
            rb.AddForce(0, UpwardForce * Time.deltaTime, 0, ForceMode.VelocityChange);
            rb.AddForce(0, -DownwardForce * Time.deltaTime, 0, ForceMode.VelocityChange);
        }

        if (Input.GetKey("s"))
        {
            rb.AddForce(0, -DownwardForce * Time.deltaTime, 0, ForceMode.VelocityChange);
        }

        if (Input.GetKey("r"))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }

        if(rb.position.y < -1f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }

    }
}
