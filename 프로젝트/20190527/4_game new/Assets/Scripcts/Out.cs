using UnityEngine;
using System.Collections;

public class Out : MonoBehaviour
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
            Uicontroller.Out = true;
        }
    }

}