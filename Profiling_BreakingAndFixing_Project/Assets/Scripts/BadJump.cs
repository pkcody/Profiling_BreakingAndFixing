using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BadJump : MonoBehaviour
{
    public float jumpForce = 8f;
    public float forwardForce = 10f;
    public float sidewaysForce = 10f;

    public int jumping;

    public Rigidbody rb;

    void Update()
    {
        if (Input.GetKey("d"))
        {
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (Input.GetKey("a"))
        {
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

      //  Ray ray = new Ray(transform.position, Vector3.down);
        if (Input.GetButtonDown("Jump"))
        {
          //  if (Physics.Raycast(ray, 0.7f))
          //  {
                GetComponent<Rigidbody>().velocity = Vector3.up * jumpForce;
                Debug.Log("jump");
           // }

            jumping++;
        }

        Debug.Log(jumping);
    }

}
