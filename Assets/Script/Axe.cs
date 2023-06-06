using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Axe : MonoBehaviour
{
    public GameObject AxeObj;
    [SerializeField]
    float AttackCount;
    [SerializeField]
    public string stat;
    float firstCount;
    int SummonCount;

    Animate A; 
    // Start is called before the first frame update
    void Start()
    {
        stat = "normal";
        firstCount = AttackCount;
        A = GameObject.FindGameObjectWithTag("Player").GetComponent<Animate>();
        SummonCount = 0;
    }

    // Update is called once per frame
    void Update()
    {
        AttackCount -= Time.deltaTime;

        switch (stat)
        {
            case "normal":

                if (AttackCount < 0)
                {
                    stat = "Attack";
                    SummonCount = 0;
                    AttackCount = firstCount;
                }

                break;

            case "Attack":
                if (A.right == true && SummonCount == 0)
                {
                    SummonCount++;
                    GameObject obj = Instantiate(AxeObj, this.transform.position, Quaternion.identity);
                    Vector3 forceDirection = new Vector3(1.0f, 2.0f, 0.0f);
                    float forceMagnitude = 2.0f;
                    Vector3 force = forceMagnitude * forceDirection;
                    Rigidbody2D rb = obj.GetComponent<Rigidbody2D>();
                    rb.AddForce(force, ForceMode2D.Impulse);
                }
                if (A.left == true && SummonCount == 0)
                {
                    SummonCount++;
                    GameObject obj = Instantiate(AxeObj, this.transform.position, Quaternion.identity);
                    Vector3 forceDirection = new Vector3(-1.0f, 2.0f, 0.0f);
                    float forceMagnitude = 2.0f;
                    Vector3 force = forceMagnitude * forceDirection;
                    Rigidbody2D rb = obj.GetComponent<Rigidbody2D>();
                    rb.AddForce(force, ForceMode2D.Impulse);
                }

                if(AttackCount < 0)
                {
                    stat = "normal";
                    AttackCount = firstCount;
                }
                

                break;
        }
    }
}
