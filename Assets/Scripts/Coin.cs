using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    public int score;
    public Score sc;
    public UpdateGcText gc;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        this.gameObject.SetActive(false);
        sc.addscore(score);
        if (score == 4)
        {
            gc.UpdateGcsText();
        }
    }
}
