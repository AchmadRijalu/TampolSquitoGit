using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Smash : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public GameObject smasheffect;

    private void OnMouseDown()
    {
        Destroy(gameObject);
        Instantiate(smasheffect, transform.position, Quaternion.identity);
    }
}