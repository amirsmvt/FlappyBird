using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlappyBird : MonoBehaviour
{
    // Start is called before the first frame update
    public Rigidbody2D rigid;
    public float speed;
    public bool paused = false;
    public GameOver game;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!paused)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                var pos = rigid.velocity;
                pos.y = 0f;
                rigid.velocity = pos;
                rigid.AddForce(Vector2.up * speed, ForceMode2D.Impulse);
            }
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Pile" || collision.gameObject.tag=="Ground")
        {
            Destroy(this.gameObject);
            game.gameOver();
        }
    }
    public void startgame()
    {
        paused = false;
        rigid.simulated = true;
    }
    public void pausedgame()
    {
        paused = true;
        rigid.simulated = false;
    }
}
