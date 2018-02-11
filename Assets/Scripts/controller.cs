using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class controller : MonoBehaviour {

    public static controller instance = null;
    public static float knife_speed = 50f;
    public static float duck_speed = 50f;

    public Text scoreText;
    public bool gameOver;
    private int score = 0;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        } 
    }

    // Use this for initialization
    void Start () {
    }
	
	// Update is called once per frame
	void Update () {
        if (gameOver)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }

    public void scoreIncrement()
    {
          score += 1;
          scoreText.text = score.ToString();
    }

    public void Die()
    {
        gameOver = true;
    }

}
