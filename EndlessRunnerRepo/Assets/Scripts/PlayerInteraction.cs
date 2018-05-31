using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInteraction : MonoBehaviour {
    public Player myPlayer ;
    public GameController gameController;
    private void OnTriggerEnter(Collider other)
    {
    if (other.tag == "Obstacle")
        {
            myPlayer.runningSpeed = 0;
        }

    if (other.tag == "Pickup")
        {
            gameController.GetComponent<Score>().score += 100;
            Destroy(other.gameObject);
        }
    }

}
