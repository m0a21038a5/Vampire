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
    float minute;
    float second;
    // Start is called before the first frame update
    void Start()
    {
        EnemyCount = 0;
        CoinCount = 0;
        minute = 0;
        second = 0;
    }

    // Update is called once per frame
    void Update()
    {
       E.GetComponent<Text>().text = EnemyCount + "";
       C.GetComponent<Text>().text = CoinCount + "";
        second += Time.deltaTime;
        if(second >= 60)
        {
            minute++;
            second = 0;
        }
        timer.GetComponent<Text>().text = minute.ToString("00") + ":" + second.ToString("00");
    }
}
