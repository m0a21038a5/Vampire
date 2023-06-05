using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animate : MonoBehaviour
{
    Animator animator;

    public float horizontal;
    public bool right;
    public bool left;

    private void Start()
    {
        left = true;
    }

    // Start is called before the first frame update
    private void Awake()
    {
        animator = GetComponentInChildren<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        animator.SetFloat("Horizontal", horizontal);
        if(horizontal == 1)
        {
            right = true;
            left = false;
        }
        if(horizontal == -1)
        {
            left = true;
            right = false;
        }
    }
}
