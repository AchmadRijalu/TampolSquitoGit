using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Smash : MonoBehaviour
{
    public float speed = 10.0f;
    private Rigidbody2D rb;
    private Vector2 screenBounds;
    
    // Start is called before the first frame update
    void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(-speed, 0);
        
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.x < -9)
        {
            Destroy(this.gameObject);
        }
    }
    public GameObject smasheffect;

    private void OnMouseDown()
    {

        Destroy(gameObject);
        Instantiate(smasheffect, transform.position, Quaternion.identity);
    }
}
