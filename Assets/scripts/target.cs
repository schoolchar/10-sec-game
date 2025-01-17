using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;
using UnityEngine.SceneManagement;


public class target : MonoBehaviour
{
    public GameObject Win;
    public static int targetCount = 0;

    // Start is called before the first frame update
    void Start()
    {
      targetCount = 0;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        targetCount += 1;
        Destroy(gameObject);
        if (targetCount == 5)
        {
            // Instantiate the new object at a specified position and rotation
            Instantiate(Win);
        }

    }


}
