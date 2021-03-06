﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Entity : MonoBehaviour {

	// attrbutes
	[HideInInspector]
	public Vector3 pos, vel, acc;
	public float maxVel, force;

	// updating the players position
	public void UpdatePosition()
	{
		vel += acc;
		vel = Vector3.ClampMagnitude(vel, maxVel);
		pos += vel;

        if(GetComponent<Rigidbody2D>()!=null)
		    GetComponent<Rigidbody2D>().velocity = vel;

		acc = Vector3.zero;
	}

	/*void CheckWall()
	{
		foreach (GameObject wall in GameObject.FindGameObjectsWithTag("Wall"))
		{
			if (wall.GetComponent<Collider2D>().Distance(GetComponent<Collider2D>()).distance < .2)
			{
				Vector2 dir = Vector2.zero;
				float lowest = 50; 
				for (int i = 0; i < 4; i++)
				{
					switch (i)
					{
						case 0:
							RaycastHit2D hitInfoUp = Physics2D.Raycast(transform.position, new Vector2(0, 1));
							//Debug.Log("Up " + hitInfoUp.distance);
							dir = new Vector2(0, 1);
							lowest = hitInfoUp.distance;
							break;
						case 1:
							RaycastHit2D hitInfoDown = Physics2D.Raycast(transform.position, new Vector2(0, -1));
							//Debug.Log("Down " + hitInfoDown.distance);
							if (lowest > hitInfoDown.distance)
							{
								dir = new Vector2(0, -1);
								lowest = hitInfoDown.distance;
							}
							break;
						case 2:
							RaycastHit2D hitInfoLeft = Physics2D.Raycast(transform.position, new Vector2(-1, 0));
							//Debug.Log("Left " + hitInfoLeft.distance);
							if (lowest > hitInfoLeft.distance)
							{
								dir = new Vector2(-1, 0);
								lowest = hitInfoLeft.distance;
							}
							break;
						case 3:
							RaycastHit2D hitInfoRight = Physics2D.Raycast(transform.position, new Vector2(1, 0));
							//Debug.Log("Right " + hitInfoRight.distance);
							if (lowest > hitInfoRight.distance)
							{
								dir = new Vector2(1, 0);
								lowest = hitInfoRight.distance;
							}
							break;
						default:
							break;
					}
				}

				if (gameObject.tag != "Orb")
				{
					if (dir.x == 1)
					{
						if (vel.x > 0)
							vel.x = 0;

						if (acc.x > 0)
							acc.x = 0;
					}

					if (dir.x == -1)
					{
						if (vel.x < 0)
							vel.x = 0;

						if (acc.x < 0)
							acc.x = 0;
					}

					if (dir.y == 1)
					{
						if (vel.y > 0)
							vel.y = 0;

						if (acc.y > 0)
							acc.y = 0;
					}

					if (dir.y == -1)
					{
						if (vel.y < 0)
							vel.y = 0;

						if (acc.y < 0)
							acc.y = 0;
					}
				}

				else if (gameObject.tag == "Orb")
				{
					if (dir.x == 1)
					{
						vel.x = -vel.x;
						acc.x = -acc.x;
					}

					if (dir.x == -1)
					{
						vel.x = -vel.x;
						acc.x = -acc.x;
					}

					if (dir.y == 1)
					{
						vel.y = -vel.y;
						acc.y = -acc.y;
					}

					if (dir.y == -1)
					{
						vel.y = -vel.y;
						acc.y = -acc.y;
					}
				}
			}
		}
	}*/
}
