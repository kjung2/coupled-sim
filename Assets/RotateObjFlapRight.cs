﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateObjFlapRight : MonoBehaviour


{
    Quaternion originalRot;
    public static int HMI_On;
    public static int Yielding;

    float Timer;
    float Timer2;
    float Timer3;
    float Timer4;

    float allTimer;

    // Start is called before the first frame update
    void Start()
    {
        originalRot = transform.rotation;

    }

    // Update is called once per frame
    void Update()
    {
        if (HMI_On == 1)
        {
            allTimer += Time.deltaTime;
            if (Yielding == 1)
            {
                //if (allTimer >=4.5 && allTimer <5) //Deploy flaps
                //{
                //    Timer += Time.deltaTime;
                //    float angle = -Mathf.Sin(Mathf.PI * Timer) * 45; //tweak this to change frequency
                //    transform.rotation = originalRot * Quaternion.AngleAxis(angle, Vector3.up);
                //}

                if (allTimer >= 8.28f && allTimer < 15.78f)
                {
                    Timer2 += Time.deltaTime;
                    float angle = Mathf.Sin(Mathf.PI * 2 * Timer2-0.5f*Mathf.PI) * (10) - (15) + 45; //tweak this to change frequency
                    transform.rotation = originalRot * Quaternion.AngleAxis(-angle, Vector3.up);
                }
                if (allTimer >= 15.78f && allTimer < 21.28f)
                {
                    Timer3 += Time.deltaTime;
                    float angle = Mathf.Sin(Mathf.PI * 2 * Timer3) * (90 / 2) - (45/2) - 45; //tweak this to change frequency
                    transform.rotation = originalRot * Quaternion.AngleAxis(angle, Vector3.up);
                }
                if (allTimer >= 21.28f && allTimer <21.78f)
                {
                    Timer4 += Time.deltaTime;
                    float angle = Mathf.Sin(Mathf.PI * 2 * Timer4 - 0.5f*Mathf.PI) * 45 - 45; //tweak this to change frequency
                    transform.rotation = originalRot * Quaternion.AngleAxis(angle, Vector3.up);
                }
            }
            else
            {
                //if (allTimer >= 8.28f && allTimer < 8.78f) //Deploy flaps
                //{
                //    Timer3 += Time.deltaTime;
                //    float angle = Mathf.Sin(Mathf.PI * 2 * Timer3 - 0.5f*Mathf.PI) * 45 - 45; //tweak this to change frequency
                //    transform.rotation = originalRot * Quaternion.AngleAxis(angle, Vector3.up);
                //}
                if (allTimer >= 8.28f && allTimer < 11.28f)
                {
                    Timer += Time.deltaTime;
                    float angle = Mathf.Sin(Mathf.PI * 2 * Timer + 0.5f*Mathf.PI) * (90 / 2) - (45 / 2) - 45; //tweak this to change frequency
                    transform.rotation = originalRot * Quaternion.AngleAxis(angle, Vector3.up);
                }
                if (allTimer >= 11.28f && allTimer < 11.78f)
                {
                    Timer4 += Time.deltaTime;
                    float angle = Mathf.Sin(Mathf.PI * 2 * Timer4 - 0.5f * Mathf.PI) * 45 - 45; //tweak this to change frequency
                    transform.rotation = originalRot * Quaternion.AngleAxis(angle, Vector3.up);
                }
            }

            //if (HMI_On == 1)
            //{
            //    if (Input.GetKey(KeyCode.Alpha7))
            //    {
            //        float angle = Mathf.Sin(5 * Time.time) * (45 / 2) - (45 / 2); //tweak this to change frequency
            //        transform.rotation = originalRot * Quaternion.AngleAxis(-angle, Vector3.up);
            //    }

            //    if (Input.GetKey(KeyCode.Alpha8))
            //    {
            //        float angle = Mathf.Sin(5 * Time.time) * (45 / 2) - (45 / 2); //tweak this to change frequency
            //        transform.rotation = originalRot * Quaternion.AngleAxis(angle, Vector3.up);
            //    }
            //}
        }
    }
}

// if (allTimer >= 5 && allTimer< 10)
//                {
//                    Timer2 += Time.deltaTime;
//                    float angle = Mathf.Sin(Mathf.PI * 2 * Timer2) * (45 / 2) - (45 / 2); //tweak this to change frequency
//transform.rotation = originalRot* Quaternion.AngleAxis(-angle, Vector3.up);
//                }
//                if (allTimer >= 10 && allTimer< 15)
//                {
//                    Timer3 += Time.deltaTime;
//                    float angle = Mathf.Sin(Mathf.PI * 2 * Timer3) * (45 / 2) - (45 / 2); //tweak this to change frequency
//transform.rotation = originalRot* Quaternion.AngleAxis(angle, Vector3.up);
//                }
//            }
//            else
//            {
//                if (allTimer >= 5 && allTimer< 8)
//                {
//                    Timer += Time.deltaTime;
//                    float angle = Mathf.Sin(Mathf.PI * 2 * Timer) * (45 / 2) - (45 / 2); //tweak this to change frequency
//transform.rotation = originalRot* Quaternion.AngleAxis(angle, Vector3.up);
//                }
//            }