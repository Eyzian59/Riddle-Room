using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class LVL2_PlayerMovement : MonoBehaviour
{
    [SerializeField] private float moveSpeed;
    Rigidbody rb;
    public GameObject Riddle1Hint1;
    public GameObject Riddle1Hint2;
    public GameObject Riddle2Hint1;
    public GameObject Riddle2Hint2;

    public float textDuration = 7f;

    public void Start()
    {
       rb = GetComponent<Rigidbody>();
       Riddle1Hint1.SetActive(false);
       Riddle1Hint2.SetActive(false);
       Riddle2Hint1.SetActive(false);
       Riddle2Hint2.SetActive(false);

    }

    private void FixedUpdate() // Using FixedUpdate for physics calculations
    {/*
        // Getting input
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        // Reversing movement direction
        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

        // Applying force instantly and stopping when key is released
        if (movement.magnitude > 0) // Check if there is input
        {
            rb.AddForce(movement.normalized * moveSpeed, ForceMode.VelocityChange);
        }
        else // If no input, stop the rigidbody
        {
            rb.velocity = Vector3.zero;
        }
    */
    }

    void OnTriggerEnter(Collider other)
    {
        // who is colliding into who?? 
        if (other.gameObject.CompareTag("pickUp"))
        {
            // collect the clue card
            other.gameObject.SetActive(false);
            Riddle1Hint1.SetActive(true);
            StartCoroutine(DisplayText(Riddle1Hint1));


        }
        if (other.gameObject.CompareTag("pickUp2"))
        {
            // collect the clue card
            other.gameObject.SetActive(false);
            Riddle1Hint2.SetActive(true);
            StartCoroutine(DisplayText(Riddle1Hint2));

        }
        if (other.gameObject.CompareTag("pickUp3"))
        {
            // collect the clue card
            other.gameObject.SetActive(false);
            Riddle2Hint1.SetActive(true);
            StartCoroutine(DisplayText(Riddle2Hint1));

        }
        if (other.gameObject.CompareTag("pickUp4"))
        {
            // collect the clue card
            other.gameObject.SetActive(false);
            Riddle2Hint2.SetActive(true);
            StartCoroutine(DisplayText(Riddle2Hint1));

        }

    }

    IEnumerator DisplayText(GameObject hintObject)
    {
        yield return new WaitForSeconds(textDuration);
        hintObject.SetActive(false);
    }





}
