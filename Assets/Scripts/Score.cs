using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Text text;
    public int scores;
    // Start is called before the first frame update
    public void addscore(int score)
    {
        scores += score;
        text.text = $"Score:" + scores;
    }

}
