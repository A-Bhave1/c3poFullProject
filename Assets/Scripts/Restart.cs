using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading;


public class Restart : MonoBehaviour
{
    Vector3 OriginalPosition;
    Quaternion OriginalRotation;

    [SerializeField] private GameObject Message;
    
    void Start()
    {
        OriginalPosition = transform.position;
        OriginalRotation = new Quaternion(transform.localRotation.x, transform.localRotation.y, transform.localRotation.z, transform.localRotation.w);
    }

    void Update()
    {
        if (transform.position.y < -10)
        {
            //transform.position = new Vector3(0, 2, 0); //for debugging
            transform.position = OriginalPosition;
            transform.rotation = OriginalRotation;

            Message.SetActive(!Message.activeSelf);
                //Thread.Sleep(5000);
            //Message.SetActive(!Message.activeSelf);
        }
    }
}
