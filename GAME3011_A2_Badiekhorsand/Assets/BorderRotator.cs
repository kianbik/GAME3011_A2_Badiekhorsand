using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BorderRotator : MonoBehaviour
{
    public float rotationRate = 3.0f;
    public float timerRate = 7;
    public bool isRotating = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        RotateBoard();


    }
    public void RotateBoard()
    {
        transform.Rotate(0.0f, rotationRate * 3.0f * Time.deltaTime, 0.0f, Space.Self);
        timerRate -= Time.deltaTime;
        isRotating = true;
    }
    public void StopRotateBoard()
    {
       
        isRotating = false;
    }
}
