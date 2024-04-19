using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class Deft : MonoBehaviour
{
    public GameObject nameTag;
    public TMP_InputField input;
    public TextMeshProUGUI output;
    public TextMeshProUGUI prompt;
    public GameObject Keycard;

    public TextMeshProUGUI answer;
    private int count = 0;

    // Start is called before the first frame update
    void Start()
    {
        nameTag.SetActive(true);
        input.onEndEdit.AddListener(CheckAnswer);
        answer.gameObject.SetActive(false);
        Keycard.SetActive(false);
        
    }

    public void CopyText()
    {
        output.text = input.text;
        CheckAnswer(output.text);
    }

    public void CheckAnswer(string text)
    {
        Debug.Log("Submitted text: " + text);

        answer.text = "Hallucination";
        if (text != answer.text)
        {
            prompt.text = "Incorrect. Please Try again";
            count++;
        } else
        {
            prompt.text = "Congratulations! You figured it out!";
            Keycard.SetActive(true);
        }

        if (count == 3)
        {
            prompt.text = "Here is the Answer: Hallucination";
            Keycard.SetActive(true);
        }

    }

}
