using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

public class updatescore : MonoBehaviour
{
    public Playermove playermovescript;
    public GameObject player;
    public Text message;
    void Start()
    {
        playermovescript = player.GetComponent<Playermove>();
    }

    // Update is called once per frame
    void Update()
    {
        if (playermovescript.canMove == false) {
            message.text = "Game Over!";
        }
    }

}
