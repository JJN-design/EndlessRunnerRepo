using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveMe : MonoBehaviour {

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
            
            transform.position = transform.position + new Vector3(0, 0, -0.1f);

       if (Input.GetKey(KeyCode.A))
        {
            transform.position = transform.position + new Vector3(0.4f, 0, 0);
        }
       if (Input.GetKey(KeyCode.D))
        {
            transform.position = transform.position + new Vector3(-0.4f, 0, 0);
        }

        }

    }

