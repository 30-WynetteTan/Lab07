using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    private Animation thisAnimation;
    public Rigidbody rb;
    public float speed = 2.5f;

    private int Score;
    public Text scoretext;

    void Start()
    {
        thisAnimation = GetComponent<Animation>();
        thisAnimation["Flap_Legacy"].speed = 3;

        rb.GetComponent<Rigidbody>();
    }

    void Update()
    {
        Score = Obstacle.score;
        scoretext.text = "Score: " + Score;      

        if (Input.GetKeyDown(KeyCode.Space))
        {
            
            thisAnimation.Play();
            rb.velocity = Vector2.up * speed;
        }
        if (transform.position.y <= -4)
        {
            SceneManager.LoadScene("GameOver");
        }
    }

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Obstacle")
        {
            SceneManager.LoadScene("GameOver");
        }      
    }
}
