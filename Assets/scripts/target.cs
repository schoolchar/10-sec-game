using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class target : MonoBehaviour
{
    public Image bar;
    public static int targetCount = 0;

    // Start is called before the first frame update
    void Start()
    {
        //sets target score to 0 at start
      targetCount = 0;
    }

    //destroys target and sets score up by 1, when shot
    //instantiates the win message when all 5 are shot
    private void OnCollisionEnter2D(Collision2D collision)
    {
        targetCount += 1;
        Destroy(gameObject);
        if (targetCount == 5)
        {
            bar.fillAmount = 1f;
        }
        if (targetCount == 1)
        {
            bar.fillAmount = 0.2f;
        }
        if (targetCount == 2)
        {
            bar.fillAmount = 0.4f;
        }
        if (targetCount == 3)
        {
            bar.fillAmount = 0.6f;
        }
        if (targetCount == 4)
        {
            bar.fillAmount = 0.8f;
        }
    }


}
