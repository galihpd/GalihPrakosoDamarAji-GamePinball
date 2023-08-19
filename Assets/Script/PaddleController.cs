using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleController : MonoBehaviour
{
    // Start is called before the first frame update

    public KeyCode input;
    public HingeJoint hinge;
    public float springPower;

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
        JointSpring jointSpring = hinge.spring;

        if(Input.GetKey(input))
        {
            jointSpring.spring = springPower;
        }

        else
        {
            jointSpring.spring = 0;
        }

        hinge.spring = jointSpring;
    }
}
