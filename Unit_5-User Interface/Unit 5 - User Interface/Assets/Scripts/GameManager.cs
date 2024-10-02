using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour

{
    public List<GameObject> targets;

    public TextMeshProUGUI scoreText;

    public TextMeshProUGUI gameOverText;

    public bool isGameActive;

    public GameObject titleScreen;

    public Button restartButton;

    private float spawnRate = 1.0f;

    private int score;

    void Start()
    {

    }

    void Update()
    {
        
    }

    IEnumerator SpawnTarget()
    {
        while(isGameActive)
        {
            yield return new WaitForSeconds(spawnRate);

            int index = Random.Range(0, targets.Count);

            Instantiate(targets[index]);
        }
    }

    public void UpdateScore(int scoreToAdd)
    {
        score += scoreToAdd;

        scoreText.text = "Score: " + score;
    }

    public void GameOver()
    {
        gameOverText.gameObject.SetActive(true);

        isGameActive = false;

        restartButton.gameObject.SetActive(true);
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void StartGame(int difficulty)
    {
        isGameActive = true;

        StartCoroutine(SpawnTarget());

        score = 0;

        UpdateScore(0);

        titleScreen.gameObject.SetActive(false);

        spawnRate /= difficulty;
    }
}
