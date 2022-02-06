using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PauseMenu : MonoBehaviour
{
    // Start is called before the first frame update
    public PileMover[] piles;
    public FlappyBird bird;
    public BackMover back;
    public BackMover ground;
    public Animation anime;
    public bool isPaused =false;
    public GameOver game;

    private void Update()
    {
        if (!game.isGameEnd)
        {
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                if (!isPaused)
                    Paused();
                else
                    Resumed();
            }
        }
    }

        public void Paused()
    {
        anime.Play("ShowMenu");
        isPaused = true;
        foreach (var pile in piles)
        {
            pile.pausedgame();
        }
        bird.pausedgame();
        back.pausedgame();
        ground.pausedgame();
    }
    public void Resumed()
    {
        anime.Play("HideMenu");
        isPaused = false;
        foreach (var pile in piles)
        {
            pile.startgame();
        }
        bird.startgame();
        back.startgame();
        ground.startgame();
    }
    public void exitgame()
    {
        Application.Quit();
    }
}
