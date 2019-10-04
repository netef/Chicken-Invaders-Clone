using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootingScript : MonoBehaviour
{
    public GameObject shot;

    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
            Instantiate(shot, transform.position, shot.transform.rotation);
    }
}
