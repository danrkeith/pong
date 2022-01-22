using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public GameObject[] uiScores;
    private Text[] scoreTexts;
    private int[] scores;

    private void Awake()
    {
        scores = new int[uiScores.Length];
        scoreTexts = new Text[uiScores.Length];

        for (int i = 0; i < uiScores.Length; i++)
        {
            scoreTexts[i] = uiScores[i].GetComponent<Text>();
        }
    }

    public void Score(string tag)
    {
        if (tag == "Left")
        {
            scores[0]++;
            scoreTexts[0].text = scores[0].ToString();
        }
        else if (tag == "Right")
        {
            scores[1]++;
            scoreTexts[1].text = scores[1].ToString();
        }
        else
        {
            Debug.Log("Cannot add score to object with tag " + tag);
        }
    }
}
