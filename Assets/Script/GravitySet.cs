using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GravitySet : MonoBehaviour
{
    [SerializeField] ScoreSystem scoreSystem;
    Rigidbody rb;
    void OnTriggerEnter(Collider other)
    {
        
        if (other.CompareTag( "Apple"))
        {
            Debug.Log("Collid");
            rb =other.gameObject.GetComponent<Rigidbody>();
            rb.useGravity = true;
            scoreSystem.Apple();
        }
        else if (other.CompareTag( "Orange"))
        {
            Debug.Log("Collid");
            rb =other.gameObject.GetComponent<Rigidbody>();
            rb.useGravity = true;
            scoreSystem.Orange();
        }
        else if (other.CompareTag("Mango"))
        {
            Debug.Log("Collid");
            rb =other.gameObject.GetComponent<Rigidbody>();
            rb.useGravity = true;
            scoreSystem.Mango();
        }
    }
}
