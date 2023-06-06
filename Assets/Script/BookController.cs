using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BookController : MonoBehaviour
{
    GameObject Book;
    [SerializeField]
    float AttackCount;
    [SerializeField]
    float BookCount;
    [SerializeField]
    private string sta;
    float firstCount;


    // Start is called before the first frame update
    void Start()
    {
        sta = "normal";
        firstCount = AttackCount;
        Book = GameObject.FindGameObjectWithTag("Book");
        Book.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        AttackCount -= Time.deltaTime;

        switch(sta)
        {
            case "normal":

                if(AttackCount < 0)
                {
                    Book.SetActive(true);
                    AttackCount = BookCount;
                    sta = "Attack";
                }
                break;

            case "Attack":

                if(AttackCount < 0)
                {
                    Book.SetActive(false);
                    AttackCount = firstCount;
                    sta = "normal";
                }
                break;
        }
    }
}
