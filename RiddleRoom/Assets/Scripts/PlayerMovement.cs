using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float moveSpeed;
    private int count;
    Rigidbody rb;
    public GameObject RiddleHint1;
    public GameObject RiddleHint2;
    public GameObject RiddleHint3;
    public TextMeshProUGUI countText;
    public float textDuration = 7f;

    public void Start()
    {
       rb = GetComponent<Rigidbody>();
       RiddleHint1.SetActive(false);
       RiddleHint2.SetActive(false);
       RiddleHint3.SetActive(false);

    }

    private void FixedUpdate() // Using FixedUpdate for physics calculations
    {
        /*// Getting input
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
            RiddleHint1.SetActive(true);
            StartCoroutine(DisplayText(RiddleHint1));
            count++;
            Debug.Log(count);
            setCountText();
        }
        if (other.gameObject.CompareTag("pickUp2"))
        {
            // collect the clue card
            other.gameObject.SetActive(false);
            RiddleHint2.SetActive(true);
            StartCoroutine(DisplayText(RiddleHint2));
            count++;
            Debug.Log(count);
            setCountText();
        }
        if (other.gameObject.CompareTag("pickUp3"))
        {
            // collect the clue card
            other.gameObject.SetActive(false);
            RiddleHint3.SetActive(true);
            StartCoroutine(DisplayText(RiddleHint3));
            count++;
            Debug.Log(count);
            setCountText();
        }

        if (other.gameObject.CompareTag("keyCard"))
        {
            other.gameObject.SetActive(false);
            SceneManager.LoadScene("Level 2");
        }


    }
    void setCountText()
    {
        countText.text = "Hints found: " + count.ToString() + "/3";
    }

    IEnumerator DisplayText(GameObject hintObject)
    {
        yield return new WaitForSeconds(textDuration);
        hintObject.SetActive(false);
    }
}
