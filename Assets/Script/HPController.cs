using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HPController : MonoBehaviour
{
    GameObject Player;
    Slider hp;
    [SerializeField]
    private float damageValue;
    Player p;
    
    // Start is called before the first frame update
    void Start()
    {
        Player = GameObject.FindGameObjectWithTag("Player");
        hp = this.gameObject.GetComponent<Slider>();
        p = Player.GetComponent<Player>();

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 Position = RectTransformUtility.WorldToScreenPoint(Camera.main, Player.transform.position);
        this.transform.position = new Vector3(Position.x, Position.y - 70, 0);

        if(p.damage)
        {
            hp.value -= damageValue;
            p.damage = false;
        }
    }
}
