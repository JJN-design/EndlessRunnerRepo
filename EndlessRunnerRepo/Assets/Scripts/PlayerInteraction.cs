using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInteraction : MonoBehaviour {
    public Player myPlayer;
    private void OnTriggerEnter(Collider other)
    {
    if (other.tag == "Obstacle")
        {
            myPlayer.runningSpeed = 0;
        }

    if (other.tag == "Pickup")
        {
            Destroy(other.gameObject);
        }
    }

}
