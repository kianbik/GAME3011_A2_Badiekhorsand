using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyMovement : MonoBehaviour
{
   
    public AudioSource lockSound;
    public int points = 0;
    public float movementSpeed = 5.0f;
    public GameObject winCanvas;
    public GameObject loseCanvas;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //get the Input from Horizontal axis
        float horizontalInput = Input.GetAxis("Horizontal");
        //get the Input from Vertical axis
        float verticalInput = Input.GetAxis("Vertical");

        //update the position
        transform.position = transform.position + new Vector3(horizontalInput * movementSpeed * Time.deltaTime, 0, verticalInput * movementSpeed * Time.deltaTime);

    }

    void OnTriggerStay(Collider collision)
    {
      
       
        if (collision.gameObject.tag == "Win")
        {
            if (!lockSound.isPlaying)
            {

                lockSound.Play();
                points++;
                if (points >= 10)
                {
                    winCanvas.SetActive(true);
                    Time.timeScale = 0f;
                }
            }
                
       
        }
    }
    void OnCollisionEnter(Collision collision)
    {


        if (collision.gameObject.tag == "Obstacle")
        {
            loseCanvas.SetActive(true);
            Time.timeScale = 0f;


        }
    }
}
