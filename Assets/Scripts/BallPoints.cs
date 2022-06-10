using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallPoints : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.name == "Base")
        {
            Debug.Log("Hit the base!");
            ScoreBoard.UpgradeScore();
            Destroy(this.gameObject);

            if (ScoreBoard.GetTotalScore() == 200)
            {
                ScoreBoard.YouWinMessage();
            }
        }
    }

    private void FinishTheGame()
    {
        Application.Quit();
    }
}
