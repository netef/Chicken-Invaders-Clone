﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplosionScript : MonoBehaviour
{
    void Awake()
    {
        Destroy(gameObject, 1);
    }
}
