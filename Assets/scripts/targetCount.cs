using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;


//script for target counter ui at top left
public class targetCount : MonoBehaviour
{
    private target target;
    public float count = 0;

    // Start is called before the first frame update
    void Start()
    {
        target = GetComponent<target>();
    }

    // Update is called once per frame
    void Update()
    {
        int value = target.targetCount;
        count = value;
        if (count == 01);
        {


        }
    }
}
