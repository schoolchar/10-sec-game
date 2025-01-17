using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cannonball : MonoBehaviour
{
    // hits object, destorys self
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy (gameObject);
    }

    // after 2 seconds, destroys self
    private void Start()
    {
        Destroy(gameObject, 2f);
    }
}
