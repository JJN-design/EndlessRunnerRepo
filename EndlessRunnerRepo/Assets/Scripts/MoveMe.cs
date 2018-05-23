using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveMe : MonoBehaviour { 

    public List<Transform> positions = new List<Transform>();
    int currentPos;

    public float speed;
    public Transform midPos;
    public Transform rightPos;
    public Transform leftPos;

    private Transform targetPos;

    void Start()
    {
        targetPos = midPos;
    }

    void Update()
    {

        this.transform.position = Vector3.Lerp(this.transform.position, targetPos.position, speed * Time.deltaTime);

        if (Input.GetKeyDown(KeyCode.A))
        {
            currentPos--;
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            currentPos++;
        }

        targetPos = positions[currentPos];

    }

  }