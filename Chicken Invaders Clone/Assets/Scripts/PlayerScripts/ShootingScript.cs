using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootingScript : MonoBehaviour
{
    public GameObject shot;
    private string playerName;

    private void Awake()
    {
        playerName = gameObject.name;
    }

    void Update()
    {

        if (playerName.Equals("Player1"))
        {
            if (Input.GetButtonDown("Controller1Square"))
                Instantiate(shot, gameObject.transform.position, shot.transform.rotation);
        }

        else if (playerName.Equals("Player2"))
            if (Input.GetButtonDown("Controller2Square"))
                Instantiate(shot, gameObject.transform.position, shot.transform.rotation);
    }
}
