using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HPController : MonoBehaviour
{
    GameObject Player;
    
    // Start is called before the first frame update
    void Start()
    {
        Player = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 Position = RectTransformUtility.WorldToScreenPoint(Camera.main, Player.transform.position);
        this.transform.position = new Vector3(Position.x, Position.y - 55, 0);
    }
}
