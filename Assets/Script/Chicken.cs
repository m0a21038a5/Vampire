using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Chicken : MonoBehaviour
{
    Slider HP;
    [SerializeField]
    private float healValue;
    // Start is called before the first frame update
    void Start()
    {
        HP = GameObject.FindGameObjectWithTag("HP").GetComponent<Slider>();
    }

    // Update is called once per frame
    void Update()
    {
      
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            Destroy(this.gameObject);
        }
    }

    private void OnDestroy()
    {
        HP.value += healValue;
    }
}
