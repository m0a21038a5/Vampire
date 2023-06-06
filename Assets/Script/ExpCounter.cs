using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ExpCounter : MonoBehaviour
{
    public float ExpValue;
    Slider ExpSlider; 

    // Start is called before the first frame update
    void Start()
    {
        ExpSlider = GameObject.FindGameObjectWithTag("Level").GetComponent<Slider>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag == "Player")
        {
            Destroy(this.gameObject);
        }
    }

    private void OnDestroy()
    {
        ExpSlider.value += ExpValue;
    }
}
