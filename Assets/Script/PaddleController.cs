using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleController : MonoBehaviour
{
    // Start is called before the first frame update

    public KeyCode input;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        ReadInput();
    }

    public void ReadInput()
    {
        if(Input.GetKey(input))
        {
            Debug.Log("Dipencet");   
        }
    }
}
