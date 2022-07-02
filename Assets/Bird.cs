using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;


public class Bird : MonoBehaviour
{
    public float hopStrength = 10f;
    public float flySpeed = 10f;
    [SerializeField] Rigidbody2D rb;
    bool gameHasEnded = false;


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Spikes"))
        {
            if (gameHasEnded == false)
            {
                
                gameHasEnded = true;
                Restart();
            }
        }
    }

    // U
    void Update()
    {
        rb.velocity = rb.velocity.normalized * flySpeed;

        rb.AddForce(Vector2.right * flySpeed, ForceMode2D.Force);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(Vector2.up * hopStrength, ForceMode2D.Force);
        }
    }
    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
