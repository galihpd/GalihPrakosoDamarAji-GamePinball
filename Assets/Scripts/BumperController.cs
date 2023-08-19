using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BumperController : MonoBehaviour
{
    public Collider bola;
    public float multiplier;
    public Color color;

    public Renderer renderer;
    public Animator animator;

    void Start(){
        renderer = GetComponent<Renderer>();
        animator = GetComponent<Animator>();
        renderer.material.color = color;
    }

    public void OnCollisionEnter(Collision collision) 
    {
        if (collision.collider == bola)
        {
            Rigidbody bolaRig = bola.GetComponent<Rigidbody>();
            bolaRig.velocity *=  multiplier;

            //animasiin
            animator.SetTrigger("hit");
            Debug.Log("Mantul");

        }   
    }
}