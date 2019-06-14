using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hideandsee : MonoBehaviour
{
    public GameObject chair1;
    public GameObject chair2;
    public GameObject chair3;
    public GameObject chair4;
    public GameObject chair5;
    public GameObject chair6;
    public GameObject half1;
    public GameObject half2;
    public GameObject half3;
    public GameObject half4;
    public GameObject half5;
    public GameObject half6;
    public GameObject item1;
    public GameObject item2;
    public GameObject item3;
    public GameObject item4;
    public GameObject item5;
    public GameObject item6;

    // Start is called before the first frame update
    void Start()
    {
        chair1.SetActive(false);
        chair2.SetActive(false);
        chair3.SetActive(false);
        chair4.SetActive(false);
        chair5.SetActive(false);
        chair6.SetActive(false);
        half1.SetActive(false);
        half2.SetActive(false);
        half3.SetActive(false);
        half4.SetActive(false);
        half5.SetActive(false);
        half6.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out hit))
            {
                BoxCollider bc = hit.collider as BoxCollider;
                if (bc != null)
                {
                    if(bc.gameObject == item1)
                    {
                        item1.SetActive(false);
                        half1.SetActive(true);
                    }
                    else if (bc.gameObject == item2)
                    {
                        item2.SetActive(false);
                        half2.SetActive(true);
                    }
                    else if (bc.gameObject == item3)
                    {
                        item3.SetActive(false);
                        half3.SetActive(true);
                    }
                    else if (bc.gameObject == item4)
                    {
                        item4.SetActive(false);
                        half4.SetActive(true);
                    }
                    else if (bc.gameObject == item5)
                    {
                        item5.SetActive(false);
                        half5.SetActive(true);
                    }
                    else if (bc.gameObject == item6)
                    {
                        item6.SetActive(false);
                        half6.SetActive(true);
                    }
                    else if (bc.gameObject == half1)
                    {
                        half1.SetActive(false);
                        chair1.SetActive(true);
                    }
                    else if (bc.gameObject == half2)
                    {
                        half2.SetActive(false);
                        chair2.SetActive(true);
                    }
                    else if (bc.gameObject == half3)
                    {
                        half3.SetActive(false);
                        chair3.SetActive(true);
                    }
                    else if (bc.gameObject == half4)
                    {
                        half4.SetActive(false);
                        chair4.SetActive(true);
                    }
                    else if (bc.gameObject == half5)
                    {
                        half5.SetActive(false);
                        chair5.SetActive(true);
                    }
                    else if (bc.gameObject == half6)
                    {
                        half6.SetActive(false);
                        chair6.SetActive(true);
                    }

                }
            }
        }

    }
}
