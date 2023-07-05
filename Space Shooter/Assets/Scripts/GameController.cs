using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject hazard;
    public int spawnCount;
    public float spawnWait;
    public float startSpawn;
    public float waveWait;

    public Text scoreText;
    public Text gameOverText;
    public Text restartText;
    public Text quitText;
    public int score;

    private bool gameOver;
    private bool restart;

     void Update()
    {
        if (restart==true) {
            if(Input.GetKeyDown(KeyCode.R)) {
                SceneManager.LoadScene(0);
            }
            if (Input.GetKeyDown(KeyCode.Q))
            {
                Application.Quit();
                Debug.Log("oyun kapand�");
            }
        }
    }
    IEnumerator SpawnValues()
    {
        yield return new WaitForSeconds(startSpawn);
        while (true) { 
        
        for(int i = 0; i < spawnCount; i++) { 
        Vector3 spawnPosition=new Vector3(Random.Range(-3,3),0,10);
        Quaternion spawnRotation = Quaternion.identity;
        Instantiate(hazard,spawnPosition,spawnRotation);
        yield return new WaitForSeconds(spawnWait);

        }
        yield return new WaitForSeconds(waveWait);
            if (gameOver==true) {
                restartText.text = "Press 'R' for Restart";
                quitText.text = "Press 'Q' for Quit";
                restart = true;
                break;
            }
        }
    }
    public void UpdateScore()
    {
        score += 10;
        scoreText.text = "Score: " + score;
    }
    public void GameOver()
    {
        gameOverText.text = "Game Over";
        gameOver = true;
    }
    void Start()
    {
        gameOverText.text = "";
        restartText.text = "";
        quitText.text = "";
        gameOver = false;
        restart = false;
        StartCoroutine(SpawnValues());
        
    }

    // Update is called once per frame
    
}
