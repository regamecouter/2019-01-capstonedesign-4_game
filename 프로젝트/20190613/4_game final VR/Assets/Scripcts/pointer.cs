using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
public class pointer : MonoBehaviour
{
    public float m_Defaultlength = 5.0f;
    public GameObject m_dot;
    public VRinputModule m_inputmodle;

    private LineRenderer m_lineRenderer = null;

    private void Awake()
    {
        m_lineRenderer = GetComponent<LineRenderer>();
    }


    void Update()
    {
        UpdateLine();
    }
    private void UpdateLine()
    {
        PointerEventData data = m_inputmodle.GetData();

        float targrtLength = data.pointerCurrentRaycast.distance == 0 ? m_Defaultlength : data.pointerCurrentRaycast.distance;

        RaycastHit hit = CreateRaycast(targrtLength);

        Vector3 endPosition = transform.position + (transform.forward * targrtLength);

        if (hit.collider != null)
            endPosition = hit.point;

        m_dot.transform.position = endPosition;

        m_lineRenderer.SetPosition(0, transform.position);
        m_lineRenderer.SetPosition(1, endPosition);
        

    }

    private RaycastHit CreateRaycast(float length)
    {
        RaycastHit hit;
        Ray ray = new Ray(transform.position, transform.forward);
        Physics.Raycast(ray, out hit, m_Defaultlength);

        return hit;
    }
}
