using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class timer : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI timerText;
    private float time;
    private float elapTime;
    public GameObject lose;
    public GameObject start;
    public int time1 = -1;

    private void Start()
    {
        Instantiate(start);
    }
    // Update is called once per frame
    void Update()
    {

        if (time1 == -1)
        {
            if (elapTime <= 2)
            {
                elapTime += Time.deltaTime;
                timerText.text = elapTime.ToString("F2");
            }
        }




        if (time1 == -1)
        {
            if (elapTime >= 2.00)
            {
                time1 += 1;
                elapTime = 0;
                set (start, true);
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
