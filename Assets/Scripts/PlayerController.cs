﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public enum PLAYERS
    {
        PLAYER_1,
        PLAYER_2
    }

    public PLAYERS player;
    private float speed = 2f;
    private float rotationSpeed = 100f;

    // Update is called once per frame
    private void Update()
    {
        float h = 0;
        float v = 0;

        if (player == PLAYERS.PLAYER_1)
        {
            h = Input.GetAxis("Horizontal");
            v = Input.GetAxis("Vertical");
        }
        else if (player == PLAYERS.PLAYER_2)
        {
            h = Input.GetAxis("Horizontal2");
            v = Input.GetAxis("Vertical2");
        }

        transform.Translate(Vector3.forward * (v * speed * Time.deltaTime));

        transform.Rotate(Vector3.up * (h * rotationSpeed * Time.deltaTime));
    }
}