using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NyamuksSmash : MonoBehaviour
{
    // Start is called before the first frame update
    float speed = 15.0f;
    float arahVertikal = 0.01f;
    float arahHorizontal = -0.01f;

    private Rigidbody2D rb;

   


    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(10, Random.Range(-4, 4), 0);
        rb = this.GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(-speed, 0);
        arahVertikal = (Random.Range(0, 4)) == 0 ? 0.01f : -0.01f;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector3(arahHorizontal, arahVertikal * speed, 0));
        if (transform.position.x < -9)
        {
            Destroy(this.gameObject);
            
        }
        if ((transform.position.y > 5) || (transform.position.y < -5))
        {
            arahVertikal = -arahVertikal;
        }
    }
    public GameObject smasheffect;

    private void OnMouseDown()
    {

        Destroy(gameObject);

        var b = Instantiate(smasheffect, transform.position, Quaternion.identity);
        if (Input.GetMouseButtonDown(0))
        {
            Destroy(b, 2f);
            ScoreScript.scoreValue += 1;
            speed += 0.02f;
        }

    }

    

    private void Wave()
    {
        

        
            Vector2 pos2 = transform.position;
            speed += 11f;
            float sin = Random.Range(Mathf.Sin(pos2.x), Mathf.Sin(pos2.x * 1));
            pos2.y = sin;

            transform.position = pos2;
        




    }
    
    
}
