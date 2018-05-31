using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {

    [Header("These will fill automatically")]
    public Text scoreText;

    public GameObject playerPrefab;
    public GameObject activePlayer;
    public int score;

    //Use this for initialization
    void Start()
    {
        //Automatically grab all UI stuff
        scoreText = GameObject.Find("Text_Score").GetComponent<Text>();

        //Override their text fields
        scoreText.text = "Score";
    
    }

    //Update is called once per frame
    void Update()
    {
        //scoreText.text = Mathf.Round(activePlayer.transform.position.z).ToString();
        scoreText.text = ((int)(score + Time.time * 5)).ToString();
    }

}
