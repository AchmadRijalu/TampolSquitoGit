using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class GameOverScript : MonoBehaviour
{

    NyamuksSmash yow;
    // Start is called before the first frame update
    public  void tryagain()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);

        
    }
    public void quit()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 2);
    }
}
