using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootingScript : MonoBehaviour
{
    private AudioSource audio;
    public AudioClip shotSound;
    public GameObject shot;
    private string playerName;

    private void Awake()
    {
        audio = GetComponent<AudioSource>();
        playerName = gameObject.name;
    }

    void Update()
    {

        if (playerName.Equals("Player1") && Input.GetButtonDown("Controller1Square"))
        {
            Instantiate(shot, gameObject.transform.position, shot.transform.rotation);
            audio.PlayOneShot(shotSound);
        }

        else if (playerName.Equals("Player2") && Input.GetButtonDown("Controller2Square"))
        {
            Instantiate(shot, gameObject.transform.position, shot.transform.rotation);
            audio.PlayOneShot(shotSound);
        }
    }
}