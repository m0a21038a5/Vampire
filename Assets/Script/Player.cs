using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    Rigidbody2D r2D;
    Vector3 moveVector;

    [SerializeField] float speed = 3f;

    Animate animate;

    // Start is called before the first frame update
    private void Awake()
    {
        r2D = GetComponent<Rigidbody2D>();
        moveVector = new Vector3();
        animate = GetComponent<Animate>();
    }

    // Update is called once per frame
    void Update()
    {
        moveVector.x = Input.GetAxisRaw("Horizontal");
        moveVector.y = Input.GetAxisRaw("Vertical");

        animate.horizontal = moveVector.x;

        moveVector *= speed;

        r2D.velocity = moveVector;
    }
}
