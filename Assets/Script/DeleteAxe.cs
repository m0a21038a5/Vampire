using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeleteAxe : MonoBehaviour
{
    GameObject Axe;
    // Start is called before the first frame update
    void Start()
    {
        Axe = GameObject.FindGameObjectWithTag("Axe");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag == "Axe")
        {
            Destroy(Axe);
        }
    }
}
