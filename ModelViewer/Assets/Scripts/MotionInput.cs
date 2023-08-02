using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Runtime.InteropServices;

public class MotionInput : MonoBehaviour
{   
    [DllImport("__Internal")]
    private static extern void Unity_MediaPipeImport();

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.O))
        {
            Unity_MediaPipeImport();  
        }
    }
}
