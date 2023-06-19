using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public GameObject menuPanel;
    public GameObject gameOverPanel;
    public GameObject character;
    public GameObject[] gameObjectwall;
    public Text maxScore;

    public int score = 0;
    public bool gameOver = false;

    public void GameStart()
    {
        menuPanel.SetActive(false);
        StartCoroutine(CreateObject());
    }
    public void GameOver()
    {
        maxScore.text = score.ToString();
        gameOver = true;
        gameOverPanel.SetActive(true);
    }

    public void Restart()
    {
        SceneManager.LoadScene(0);
    }

    IEnumerator CreateObject()
    {
        while (gameOver == false)
        {
            //int i = Random.Range(0, gameObjectwall.Length);
            //Instantiate(gameObjectwall[i], new Vector3(0, (float)1.2, 4), Quaternion.identity);
            for (int i = 0; i <= gameObjectwall.Length; i++){
                gameObjectwall[i].SetActive(true);

                int score = i;
                PlayerPrefs.SetInt("MaxScore", i);
                yield return new WaitForSeconds(8f);
            }
        }
    }
}
