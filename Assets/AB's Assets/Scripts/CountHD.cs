using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CountHD : MonoBehaviour
{
    public int hotdogs = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
     if(hotdogs == 10){
         Application.Quit();
     }   
    }

    private void OnGUI()
    {
        GUI.Label(new Rect(20, 20, 200, 20), "Hotdogs : " + hotdogs + "/10");
    }
}
