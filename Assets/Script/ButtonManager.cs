using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonManager : MonoBehaviour
{
    Axe a;
    Leveltext Lv;
    GameManager gm;
    BookController b;
    public GameObject Canvas;
    public GameObject Canvas2;

  
    // Start is called before the first frame update
    void Start()
    {
        a = GameObject.FindGameObjectWithTag("Player").GetComponent<Axe>();
        Lv = GameObject.FindGameObjectWithTag("Level").GetComponent<Leveltext>();
        gm = GameObject.FindGameObjectWithTag("Master").GetComponent<GameManager>();
        b = GameObject.FindGameObjectWithTag("Master").GetComponent<BookController>();
        a.enabled = false;
        b.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
      
    }

    public void OnAxe()
    {
        a.enabled = true;
        Lv.Levelup = false;
        Time.timeScale = 1;
        Canvas.SetActive(false);
    }

    public void OnKnife()
    {
        Time.timeScale = 1;
      
        Lv.Levelup = false;
        Canvas.SetActive(false);
    }

    public void OnWater()
    {
        Time.timeScale = 1;
       
        Lv.Levelup = false;
        Canvas.SetActive(false);
    }

    public void Whip_02()
    {
        Time.timeScale = 1;
      
        Lv.Levelup = false;
        Canvas2.SetActive(false);
    }

    public void OnBook()
    {
        Time.timeScale = 1;
        
        b.enabled = true;
        Lv.Levelup = false;
        Canvas2.SetActive(false);
    }

    public void Funasi()
    {
        Time.timeScale = 1;
        gm.Funasi = true;
        Lv.Levelup = false;
        Canvas2.SetActive(false);
    }
}
