using UnityEngine;
using System.Collections;

public class Clear : MonoBehaviour
{
    void Start()
    {

    }

    void Update()
    {

    }

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
            Uicontroller.Clear = true;
        }
    }

}