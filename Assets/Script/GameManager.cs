using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    Leveltext Lv;
    public GameObject Level_01;

    // Start is called before the first frame update
    void Start()
    {
        Lv = GameObject.FindGameObjectWithTag("Level").GetComponent<Leveltext>();
        Level_01.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(Lv.Levelup == true)
        {
            Time.timeScale = 0;
            Level_01.SetActive(true);
        }
    }
}
