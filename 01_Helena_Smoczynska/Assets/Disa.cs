using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disa : MonoBehaviour{

void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider)
        {

            Destroy(gameObject);

        }
    }
}

    
    

