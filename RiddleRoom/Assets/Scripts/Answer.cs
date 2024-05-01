using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class Answer : MonoBehaviour
{
    public bool inRange;
    public KeyCode interactKey;
    public UnityEvent interactAction;
    bool sceneLoaded;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(inRange)
        {
            if(Input.GetKeyDown(interactKey))
            {
                interactAction.Invoke();
            }
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            inRange = true;
            Debug.Log("In");
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            inRange = false;
            Debug.Log("Out");
        }
    }
    public void SceneSwitcher()
    {
        Cursor.lockState = CursorLockMode.None;
        SceneManager.LoadScene("Answer 1");
        sceneLoaded = true;
        Debug.Log("Loaded");
        //SetActiveSceneButton();
    }
    public IEnumerator Delay()
    {
        yield return new WaitForSeconds(.2f);
    }
    /*void SetActiveSceneButton()
    {
        // Allow this other Button to be pressed when the other Button has been pressed (Scene 2 is loaded)
        if (sceneLoaded == true)
        {
            Debug.Log("Called");
            StartCoroutine(Delay());
            // Set Scene2 as the active Scene
            SceneManager.SetActiveScene(SceneManager.GetSceneByName("Answer 1"));

            // Ouput the name of the active Scene
            // See now that the name is updated
            Debug.Log("Active Scene : " + SceneManager.GetActiveScene().name);
        }
    }*/
}
