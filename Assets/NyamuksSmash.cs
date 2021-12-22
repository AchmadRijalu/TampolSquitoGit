using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class NyamuksSmash : MonoBehaviour
{
    // Start is called before the first frame update
    float speed = 1.0f;
    float arahVertikal = 0.01f;
    float arahHorizontal = -0.01f;

    private Rigidbody2D rb;

    bool isPaused = false;
    

    

    // Start is called before the first frame update
    public void Start()
    {
        transform.position = new Vector3(10, Random.Range(-4, 5), 0);
        rb = this.GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(-speed, 0);
        arahVertikal = (Random.Range(0, 2)) == 0 ? 0.01f : -0.01f;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector3(arahHorizontal, arahVertikal * speed, 0));
        if (transform.position.x < -9)
        {
            
            gameoverscreen();
            
            Destroy(this.gameObject);

        }
        if ((transform.position.y > 3) || (transform.position.y < -2))
        {
            arahVertikal = -arahVertikal;
        }
    }
    public GameObject smasheffect;
    

    private void OnMouseDown()
    {

        Destroy(gameObject);

        var b = Instantiate(smasheffect, transform.position, Quaternion.identity);
        
            Destroy(b, 2f);
            ScoreScript.scoreValue += 1;
            speed += 0.02f;
        

    }

    public void gameoverscreen()
    {

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        ScoreScript.scoreValue = 0;
        
    }

    private void Wave()
    {
        

        
            Vector2 pos2 = transform.position;
            speed += 11f;
            float sin = Random.Range(Mathf.Sin(pos2.x), Mathf.Sin(pos2.x * 1));
            pos2.y = sin;

            transform.position = pos2;
        




    }
    public void pauseGame()
    {
        if (!isPaused)
        {
            Time.timeScale = 0;
            isPaused = true;
        }

    }


}
