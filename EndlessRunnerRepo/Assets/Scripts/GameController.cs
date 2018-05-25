using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour {

    //public GameObject groundPiece;
    //public GameObject groundPiece_Laser_Left;
    //public GameObject groundPiece_Pillar_Left;
    //public GameObject groundPiece_Pillar_Right;
    //public GameObject groundPiece_Diamond_Center;
    //public GameObject groundPiece_Diamond_Left;

    public int groundPieceCounter = 0;
    public int depthOfGroundPiece = 2;

    public float playerPositionCounter = 0;
    public GameObject player;

    public List<GameObject> groundPieces = new List<GameObject>();

    private void BuildGround()
    {
        Instantiate(groundPieces[Random.Range(0, groundPieces.Count)],
            Vector3.forward * groundPieceCounter * depthOfGroundPiece,
            Quaternion.identity);
        groundPieceCounter++;
    }

    void Update()
    {
        if (player.transform.position.z > playerPositionCounter)
        {
            playerPositionCounter += depthOfGroundPiece;
            BuildGround();
        }
    }


    void Start()
    {
        for (int i = 0; i < 40; i++)
        {
            BuildGround();
        }

    }

}
