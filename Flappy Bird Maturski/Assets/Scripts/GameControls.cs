using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameControls: MonoBehaviour {

    public static GameControls instance;
    public GameObject gameOverText;
    public bool endGame = false;

    private int score = 0;
    public Text scoreText;

    public ParticleSystem star;

    private Rigidbody2D playerBody;

    // Use this for initialization
    private void Start()
    {
        playerBody = GetComponent<Rigidbody2D>();
       
    }
    void Awake ()
    {
        if (instance == null)
        {
            instance = this;
        }
        else Destroy(gameObject);
	}

    // Update is called once per frame
    void Update()
    {
        if (endGame ==true && Input.GetMouseButtonDown(0))
        {
            int currentScene = SceneManager.GetActiveScene().buildIndex;
            SceneManager.LoadScene(currentScene);

        }
	}

    public void CatDied()
    {
        gameOverText.SetActive(true);
        endGame = true;
    }

    public void Score()
    {
        star.Play();
        score = score + 1;
        scoreText.text = "Score:" + score.ToString();
       
       
    }
}
