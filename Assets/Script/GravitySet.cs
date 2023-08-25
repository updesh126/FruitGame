using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GravitySet : MonoBehaviour
{
    Rigidbody rb;
    void OnTriggerEnter(Collider other)
    {
        
        if (other.tag == "Fruit")
        {
            Debug.Log("Collid");
            rb =other.gameObject.GetComponent<Rigidbody>();
            rb.useGravity = true;
        }
    }
}
