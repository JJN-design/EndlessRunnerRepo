using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour {

	void OnTriggerEnter(Collider other)
    {
		if (other.tag == "Pickup")
        {
            Destroy(other.gameObject);
        }
	}
	
}
