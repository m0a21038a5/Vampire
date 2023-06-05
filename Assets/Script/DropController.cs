using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropController : MonoBehaviour
{
    public Vector3 Candle;
    public int dropCount;
    public bool C;
    [SerializeField]
    List<GameObject> droplist = new List<GameObject>();
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(C)
        {
            Instantiate(droplist[dropCount], Candle, Quaternion.identity);
            C = false;
        }
    }
}
