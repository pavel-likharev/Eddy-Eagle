using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] float torqeForce = 3f;

    Rigidbody2D playerRB;

    // Start is called before the first frame update
    void Start()
    {
        playerRB = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            playerRB.AddTorque(torqeForce);
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            playerRB.AddTorque(-torqeForce);
        }
    }
}
