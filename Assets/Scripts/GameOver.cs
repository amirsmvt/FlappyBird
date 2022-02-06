using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement; 

public class GameOver : MonoBehaviour
{
    public PileMover[] piles;
    public FlappyBird bird;
    public BackMover back;
    public BackMover ground;
    public Score score;
    public Text txt;
    public bool isGameEnd=false;
    public Animation anime;


    private void OnEnable()
    {
        txt.text = score.text.text;
    }
    
    public void exitgame()
    {
        Application.Quit();
    }
    public void gameOver()
    {
        this.gameObject.SetActive(true);
        isGameEnd = true;
        anime.Play("ShowMenu");
        foreach (var pile in piles)
        {
            pile.pausedgame();
        }
        bird.pausedgame();
        back.pausedgame();
        ground.pausedgame();
        txt.text = score.text.text;
    }
    public void restart()
    {
        SceneManager.LoadScene("StartGame");
    }
}
