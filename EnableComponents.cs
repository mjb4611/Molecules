using UnityEngine;
using System.Collections;

public class EnableComponents : MonoBehaviour
{
    private Spin mySpin;


    void Start()
    {
        mySpin = GetComponent<Spin>();
    }

    void Update()
    {
        for (int i = 0; i < Input.touchCount; ++i)
        {
            if (Input.GetTouch(i).phase == TouchPhase.Began)
            {
                mySpin.enabled = !mySpin.enabled;
            }
        }
    }
}