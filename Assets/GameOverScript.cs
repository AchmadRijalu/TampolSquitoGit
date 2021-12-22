using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class GameOverScript : MonoBehaviour
{

    Text score,highscore;

    void Start()
    {
        score = GameObject.Find("Score").GetComponent<Text>();
        score.text = "Score : " + ScoreScript.scoreValue / 2;
        highscore = GameObject.Find("Highscore").GetComponent<Text>();
        highscore.text = "Highscore : " + ScoreScript.highscore / 2;
    }

    NyamuksSmash yow;
    // Start is called before the first frame update
    public  void tryagain()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
        ScoreScript.scoreValue = 0;
    }
    public void quit()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 2);
        ScoreScript.scoreValue = 0;
    }
}
