using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Unity.VisualScripting;

public class timer : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI timerText;
    private float time;
    private float elapTime;
    public int time1 = 0;


    // Update is called once per frame
    void Update()
    {


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
