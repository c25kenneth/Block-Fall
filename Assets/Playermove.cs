using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playermove : MonoBehaviour
{
    public float speed = 50f;
    public float move;

    public bool canMove = true; 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (canMove) {
            move = Input.GetAxisRaw("Horizontal") * Time.deltaTime * speed;
            transform.Translate(move, 0, 0);

            transform.position = new Vector3((Mathf.Clamp(transform.position.x, -8, 8)), transform.position.y, transform.position.z);
        }

    }
}
