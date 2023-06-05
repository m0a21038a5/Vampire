using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackController : MonoBehaviour
{
    Animate A;
    GameObject whip_R;
    GameObject whip_L;
    [SerializeField]
    float AttackCount;
    [SerializeField]
    float CollisionCount;
    [SerializeField]
    public string state;
    float firstCount;
    // Start is called before the first frame update
    void Start()
    {
        whip_R = GameObject.FindGameObjectWithTag("Whip");
        whip_R.SetActive(false);
        whip_L = GameObject.FindGameObjectWithTag("Whip_L");
        whip_L.SetActive(false);
        firstCount = AttackCount;
        state = "normal";
        A = GameObject.FindGameObjectWithTag("Player").GetComponent<Animate>();
    }

    // Update is called once per frame
    void Update()
    {
        AttackCount -= Time.deltaTime;

        switch(state)
        {
            case "normal":

                if (AttackCount < 0)
                {
                    if (A.right == true)
                    {
                        whip_R.SetActive(true);
                    }
                    if (A.left == true)
                    {
                        whip_L.SetActive(true);
                    }
                    state = "Attack";
                    AttackCount = CollisionCount;
                }

                break;

            case "Attack":

                if(AttackCount < 0)
                {
                  if(whip_R.activeSelf == true)
                    {
                        whip_R.SetActive(false);
                    }
                  if(whip_L.activeSelf == true)
                    {
                        whip_L.SetActive(false);
                    }
                    state = "normal";
                    AttackCount = firstCount;
                }

                break;
        }
    }
}
