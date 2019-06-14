using UnityEngine;
using System.Collections;

public class item2 : MonoBehaviour
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
            Uicontroller.item2 = true;
        }
    }

}