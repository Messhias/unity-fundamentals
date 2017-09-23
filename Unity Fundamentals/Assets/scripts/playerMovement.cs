using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour {

    public float speed = 5.0f;
    public float rotateSpeed = 100.0f;
    	
	// Update is called once per frame
	void Update () {

        Movement();
        
    }

    void Movement()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            this.transform.Translate(new Vector3(0, 0, speed * Time.deltaTime));
        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            this.transform.Translate(new Vector3(0, 0, -speed * Time.deltaTime));
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            this.transform.Rotate(new Vector3(0, -rotateSpeed * Time.deltaTime, 0));
            this.transform.Translate(new Vector3(-speed * Time.deltaTime, 0, 0));
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            this.transform.Rotate(new Vector3(0, rotateSpeed * Time.deltaTime, 0));
            this.transform.Translate(new Vector3(speed * Time.deltaTime, 0, 0));
        }

        if (Input.GetKey(KeyCode.W))
        {
            this.transform.Translate(new Vector3(0, speed * Time.deltaTime, 0));
        }
        else if (Input.GetKey(KeyCode.S))
        {
            this.transform.Translate(new Vector3(0, -speed * Time.deltaTime, 0));
        }

    }
}
