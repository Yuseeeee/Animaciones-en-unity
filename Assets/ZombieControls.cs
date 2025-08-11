using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieControls : MonoBehaviour
{
    [SerializeField] Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        anim.SetBool("IsWaltkins", false);

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            anim.SetBool("IsWaltkins", true);
        }
        if (Input.GetKeyUp(KeyCode.W))
        {
            anim.SetBool("IsWaltkins", false);
        }
    }
}
