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
    public GameObject lose;
    public GameObject start;
    public int time1 = -1;
    public int started = 0;

    private void Start()
    {
        Instantiate(start);
        start.SetActive(true);

    }
    // Update is called once per frame
    void Update()
    {
        if (started == 0)
        {
            start.SetActive(true);
        }
        if (started == 1)
        {
            start.SetActive(false);
        }

        if (time1 == -1)
        {
            if (elapTime <= 2.00)
            {


                elapTime += Time.deltaTime;
                timerText.text = elapTime.ToString("F2");


            }
            if (elapTime >= 1.99)
            {
                started += 1;
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
