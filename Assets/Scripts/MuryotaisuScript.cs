using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MuryotaisuScript : MonoBehaviour
{
    float walkingSpeed = 2;
    float turningSpeed = 90;
    float jumpHigh = 50;
    Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        animator.SetBool("is_walking", false);
        // Walking forward
        if (Input.GetKey(KeyCode.W))
        {
            animator.SetBool("is_walking", true);
            transform.position += walkingSpeed * transform.forward * Time.deltaTime;
        }

        if (!Input.GetKey(KeyCode.W))
        {
            animator.SetBool("is_walking", false);
        }

        // Walking backward
        //if (Input.GetKey(KeyCode.S))
        //{
        //    animator.SetBool("is_walking", true);
        //    transform.position -= walkingSpeed * transform.forward * Time.deltaTime;
        //}

        // Turning
        if (Input.GetKey(KeyCode.D))
        {
            animator.SetBool("is_walking", true);
            transform.Rotate(Vector3.up, turningSpeed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.A))
        {
            animator.SetBool("is_walking", true);
            transform.Rotate(Vector3.down, turningSpeed * Time.deltaTime);
        }

        // Jumping
        if (Input.GetKeyDown(KeyCode.Space))
        {
            animator.SetBool("is_jumping", true);
            transform.position += jumpHigh * transform.up * Time.deltaTime;
        }

        if (!Input.GetKeyDown(KeyCode.Space)) 
        {
            animator.SetBool("is_jumping", false);
        }
    }
}
