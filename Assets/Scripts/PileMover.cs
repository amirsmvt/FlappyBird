using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PileMover : MonoBehaviour
{
    public Transform left;
    public Transform right;
    public float miny;
    public float maxy;
    public float speed;
    public GameObject coin;
    public bool paused =false ;
    // Start is called before the first frame update
    void Start()
    {
        var pos =transform.localPosition;
        pos.y = Random.Range(miny, maxy);
        transform.localPosition = pos;
    }

    // Update is called once per frame
    void Update()
    {
        if (!paused)
        {
            transform.Translate(speed * Vector2.left);
            if (transform.localPosition.x < left.position.x)
            {
                var pos = transform.localPosition;
                pos.x = right.position.x;
                pos.y = Random.Range(miny, maxy);
                transform.localPosition = pos;
                coin.SetActive(true);
            }
        }
    }
    public void startgame()
    {
        paused = false;
    }
    public void pausedgame()
    {
        paused = true;
    }
}
