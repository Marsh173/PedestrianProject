using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Elevator : MonoBehaviour
{
    public Transform player;

    public Transform upperpos;
    public Transform downpos;

    bool limit = true;
    public float speed;

    void Start()
    {
        
    }
    void Update()
    {
        ControlElevator();
    }

    void ControlElevator()
    {
        if(Vector2.Distance(player.position, transform.position)<0.7f)
        {
            Debug.Log("Enter");
            //if (Input.GetKeyDown(KeyCode.W) && !limit)
            if(!limit)
            {
                transform.position = Vector2.MoveTowards(transform.position, upperpos.position, speed * Time.deltaTime);
            }
            if (Input.GetKeyDown(KeyCode.S) && !limit)
            {
                transform.position = Vector2.MoveTowards(transform.position, downpos.position, speed * Time.deltaTime);
            }

            if(transform.position.y <= downpos.position.y || transform.position.y >= upperpos.position.y)
            {
                limit = true;
            }
            else
            {
                limit = false;
            }

            /*
            if(transform.position.y <= downpos.position.y)
            {
                isdown = true;
            }
            else if(transform.position.y >= upperpos.position.y)
            {
                isdown = false;
            }*/
        }

        
    }
}
