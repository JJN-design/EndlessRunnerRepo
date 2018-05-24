using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour {

    public GameObject groundPiece;
    public GameObject groundPieceLaser;
    public GameObject groundPiecePillar;

    public int groundPieceCounter = 0;
    public int depthOfGroundPiece = 2;

    public float playerPositionCounter = 0;
    public GameObject player;

    private void BuildGround()
    {

        GameObject groundPieceToPlace = null;
        int randomPiece = Random.Range(0, 3);

        if (randomPiece == 0)
        {
            groundPieceToPlace = groundPiece;
        }
        else
            if (randomPiece == 1)
        {
            groundPieceToPlace = groundPieceLaser;
        }
        else
            if (randomPiece == 2)
        {
            groundPieceToPlace = groundPiecePillar;
        }

        Instantiate(groundPieceToPlace, Vector3.forward * groundPieceCounter * depthOfGroundPiece, Quaternion.identity);
        groundPieceCounter++;
    }

    void Update()
    {
        if (player.transform.position.z > playerPositionCounter) ;
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
