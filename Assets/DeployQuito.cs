using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeployQuito : MonoBehaviour
{
    public GameObject mosquito;
     float respawnTime = 0.70f;
    private Vector2 screenBounds;
    // Start is called before the first frame update
    void Start()
    {
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
        StartCoroutine(Mosquito());
    }
    private void spawnEnemy()
    {
        respawnTime -= 0.001f;
        GameObject spawn = Instantiate(mosquito) as GameObject;
        spawn.transform.position = new Vector2(Random.Range(12,14), Random.Range(-4, 6));
        
    }

    IEnumerator Mosquito()
    {
        while (true)
        {
            yield return new WaitForSeconds(respawnTime);
            spawnEnemy();

        }
        
    }


    
    // Update is called once per frame
    void Update()
    {
       
    }
}
