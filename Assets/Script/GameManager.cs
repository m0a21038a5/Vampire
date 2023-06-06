using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    Leveltext Lv;
    public GameObject Level_01;
    [SerializeField]
    List<GameObject> Canvaslist = new List<GameObject>();
    public int CanvasCount;

    GameObject[] Enemys;

    public bool Funasi;
    // Start is called before the first frame update
    void Start()
    {
        Lv = GameObject.FindGameObjectWithTag("Level").GetComponent<Leveltext>();
        foreach(GameObject obj in Canvaslist)
        {
            obj.SetActive(false);
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        Enemys = GameObject.FindGameObjectsWithTag("Enemy");
        if (Lv.Levelup == true)
        {
            Time.timeScale = 0;
            CanvasCount = Random.Range(0, 2);
            Canvaslist[CanvasCount].SetActive(true);
        }

        if(Funasi == true)
        {
            foreach (GameObject e in Enemys)
            {
                Destroy(e);
            }
            Funasi = false;
        }
    }
}
