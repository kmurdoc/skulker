﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonController : MonoBehaviour
{

    [SerializeField] private GameObject door;
    [SerializeField] private GameObject player;
    [SerializeField] private GameObject toolTip;
    public float speed;
    private bool open = false;

    void Update()
    {
        toolTip.SetActive(false);
        if (Vector3.Distance(player.transform.position, gameObject.transform.position) <= 1.5f) {
            toolTip.SetActive(true);
            Interact();
        } 
        door.transform.rotation = Quaternion.Slerp(door.transform.rotation, Quaternion.Euler( (open ? 0 : -90) , 0, 0), speed * Time.deltaTime);
        
    }

    void Interact()
    {
        if (Input.GetButtonDown("Interact")) {            
            open = !open;
        }
    }

}