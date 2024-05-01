using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class ExitHandler : MonoBehaviour
{
    public void Exit()
    {
        SceneManager.LoadScene("Level 1");
        Cursor.lockState = CursorLockMode.Locked;
    }
}
