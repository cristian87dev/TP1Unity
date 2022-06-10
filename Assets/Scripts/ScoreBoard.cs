using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreBoard : MonoBehaviour
{
    private static int totalScore = 0;
    private static string boardMessage = "";

    private void OnGUI()
    {
        GUI.Box(new Rect(100, 100, 200, 100), boardMessage);
    }

    public static int GetTotalScore()
    {
        return totalScore;
    }

    public static void UpgradeScore()
    {
        totalScore += 100;
        boardMessage = "Score = " + totalScore.ToString();
    }

    public static void YouWinMessage()
    {
        boardMessage = "You Win!!!!!!! Well DONE!";
    }
}
