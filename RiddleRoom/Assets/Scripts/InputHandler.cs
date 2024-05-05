using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class InputHandler : MonoBehaviour
{
    [SerializeField] InputField inputField;
    [SerializeField] Text resultText;

    public void validateInput()
    {
        Cursor.lockState = CursorLockMode.Confined;
        string input = inputField.text;
        Debug.Log(input.ToUpper());

        if (input.ToUpper().Equals("HALLUCINATION"))
        {
            resultText.text = "Correct";
            resultText.color = Color.green;
            SceneManager.LoadScene("Level 2");
        }
        else
        {
            resultText.text = "Incorrect";
            resultText.color = Color.red;
        }

    }
}
