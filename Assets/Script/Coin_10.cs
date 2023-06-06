using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin_10 : MonoBehaviour
{
    TextController t;
    // Start is called before the first frame update
    void Start()
    {
        t = GameObject.FindGameObjectWithTag("EnemyManager").GetComponent<TextController>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Destroy(this.gameObject);
        }
    }

    private void OnDestroy()
    {
        t.CoinCount += 10;
    }
}
