
using UnityEngine;

public class Pickupobject : MonoBehaviour {

    private void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag == "Player")
        {
            print("Item pickup");
            Destroy(gameObject);
        }
    }
}
