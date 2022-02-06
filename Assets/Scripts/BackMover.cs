using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackMover : MonoBehaviour
{
    public Renderer rend;
    public float speed;
    public bool paused = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!paused)
        {
            var tmp = rend.material.mainTextureOffset;
            tmp.x += speed;
            rend.material.mainTextureOffset = tmp;
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
