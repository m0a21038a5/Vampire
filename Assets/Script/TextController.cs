using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextController : MonoBehaviour
{
    public Text E;
    public int EnemyCount;
    public Text C;
    public int CoinCount;
    public Text timer;
    public float time;
    // Start is called before the first frame update
    void Start()
    {
        EnemyCount = 0;
        CoinCount = 0;
    }

    // Update is called once per frame
    void Update()
    {
       E.GetComponent<Text>().text = EnemyCount + "";
       C.GetComponent<Text>().text = CoinCount + "";
    }
}
