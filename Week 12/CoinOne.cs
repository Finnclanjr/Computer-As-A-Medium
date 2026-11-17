using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinOne : MonoBehaviour
{
    private GameManager gameManager;


    // Start is called before the first frame update
    void Start()
    {
        Destroy(this.gameObject, 2.5f);
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    private void OnTriggerEnter2D(Collider2D whatDidIHit)
    {
        if (whatDidIHit.tag == "Player")
        {
            Destroy(this.gameObject);
            gameManager.AddScore(1);
        }
    }




}
