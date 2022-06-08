using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameMenuOver : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject gameMenuOver;
    public TextMeshProUGUI score;
    bool gameOverFlag = false;
    void Start()
    {
        FindObjectOfType<PlayerControls>().GameOverEvent.AddListener(gameOver);
    }

    // Update is called once per frame
    void Update()
    {
        if (gameOverFlag && Input.GetKeyDown(KeyCode.Space))
        {
            gameOverFlag = false;
            SceneManager.LoadScene(0);
        }
    }

    void gameOver()
    {
        score.text = Mathf.RoundToInt(Time.timeSinceLevelLoad).ToString();
        gameOverFlag = true;
        gameMenuOver.SetActive(true);
    }
}
