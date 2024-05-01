using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crosshair : MonoBehaviour
{
    public Texture2D texture;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnGUI()
    {
        float xMin = (Screen.width / 2) - (texture.width / 2);
        float yMin = (Screen.height / 2) - (texture.height / 2);
        GUI.DrawTexture(new Rect(xMin, yMin, texture.width, texture.height), texture);
    }
}
