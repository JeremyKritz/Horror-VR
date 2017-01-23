using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dissapear : MonoBehaviour {
    private bool test = true;

    void OnTriggerEnter(Collider col)
    {
        Renderer r = col.gameObject.GetComponent<Renderer>();
        if (r.enabled == true)
        {

            r.enabled = false;
            
        }
        else {
            r.enabled = true;
         }
    }
	
}
