using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NyamuksSmash : MonoBehaviour
{
    // Start is called before the first frame update
      float speed = 10.0f;

    private Rigidbody2D rb;

   


    // Start is called before the first frame update
    void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(-speed, 0);

        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < -9)
        {
            Destroy(this.gameObject);
            
        }

        
            Wave();
        

        
            
       
 ;    }
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
