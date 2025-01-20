using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Unity.VisualScripting;
using UnityEngine.SceneManagement;

public class timer : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI timerText;
    private float time;
    private float elapTime;
    public int time1 = 0;
    private target target;
    public float winCon = 0;

    void Start()
    {
        target = GetComponent<target>();
    }

    // Update is called once per frame
    void Update()
    {
        int value = target.targetCount;
        winCon = value;

        if (time1 == 0)
        {
            if (elapTime <= 10.00)
            {
                elapTime += Time.deltaTime;
                timerText.text = elapTime.ToString("F2");
            }
            if (elapTime >= 10.00)
            {
                time1 += 1;
                SceneManager.LoadScene(4);
            }
            if (winCon == 5)
            {
                SceneManager.LoadScene(3);
            }
        }


      //  if (time1 == 0)
       // {
      //      if (time <= 10)
        //    {
         //       elapTime += Time.deltaTime;
       //         timerText.text = elapTime.ToString("F2");
        //    }
      //  }




      //  if (time1 == 0)
     //   {
      //      if (elapTime >= 10.00)
       //     {
       //         time1 += 1;
       //         Instantiate(lose);
     //       }
      //  }


    }
}
