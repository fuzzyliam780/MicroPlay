﻿using System.Collections;
using System.Collections.Generic;
using Platformer.Gameplay;
using Platformer.Mechanics;
using UnityEngine;
using static Platformer.Core.Simulation;

public class Ladder : MonoBehaviour
{
    internal Collider2D _collider;

    public Bounds Bounds => _collider.bounds;

	void OnCollisionEnter2D(Collision2D collision)
	{
		var player = collision.gameObject.GetComponent<PlayerController>();
		if (player != null)
		{
            player.onLadder = true; 
		}
    }
    void OnCollisionExit2D(Collision2D collision)
    {
        var player = collision.gameObject.GetComponent<PlayerController>();
        if (player != null)
        {
            player.onLadder = false;
        }
    }
}
