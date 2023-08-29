using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreSystem : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI AppleTxt;
    [SerializeField] TextMeshProUGUI OrangeTxt;
    [SerializeField] TextMeshProUGUI MangoTxt;
    [SerializeField] TextMeshProUGUI ScoreTxt;
    static int AScore = 0;
    static int OScore = 0;
    static int MScore = 0;
    static int TScore = 0;

    public void Apple()
    {
        AScore++;
        AppleTxt.text= AScore.ToString();
    }
    public void Orange()
    {
        OScore++;
        OrangeTxt.text= OScore.ToString();
    }
    public void Mango()
    {
        MScore++;
        MangoTxt.text= MScore.ToString();
    }
    void Update()
    {
        TScore = (AScore*4)+(OScore*6)+(MScore*4);
        ScoreTxt.text= TScore.ToString();
    }
}
