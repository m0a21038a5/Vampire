using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Candle : MonoBehaviour
{
    DropController d;
    // Start is called before the first frame update
    void Start()
    {
        d = GameObject.FindGameObjectWithTag("GameManager").GetComponent<DropController>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag == "Whip")
        {
            Destroy(this.gameObject);
            Debug.Log("Attack");
        }
    }

    private void OnDestroy()
    {
        d.C = true;
        d.Candle = this.transform.position;
        d.dropCount = Random.Range(0, 2);
    }

}
