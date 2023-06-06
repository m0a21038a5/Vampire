using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Leveltext : MonoBehaviour
{
    private const double V = 0.2;
    public Text LevelText;
    Slider L;
    private float LevelCount;
    EnemyController e;
    public bool Levelup;
    // Start is called before the first frame update
    void Start()
    {
        L = this.gameObject.GetComponent<Slider>();
        e = GameObject.FindGameObjectWithTag("EnemyManager").GetComponent<EnemyController>();
        LevelCount = 1;
        Levelup = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(L.value == 1)
        {
            LevelCount += 1;
            L.value = 0;
            e.spawnInterval = e.spawnInterval * 0.7f;
            Levelup = true;
        }
        LevelText.GetComponent<Text>().text = "Lv" + LevelCount;
    }
}
