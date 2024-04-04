using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Obstacle : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        // Check if the colliding object has a specific tag (optional)
        if (collision.gameObject.tag == "Player")
        {
            // Load the next level
            SceneManager.LoadScene(0);
        }
    }
}
