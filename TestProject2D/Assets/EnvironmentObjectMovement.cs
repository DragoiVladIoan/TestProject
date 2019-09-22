using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnvironmentObjectMovement : MonoBehaviour
{
    public float playerSpeed = 5;
    private Vector2 screenBounds;

    // Start is called before the first frame update
    void Start()
    {
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 pos = transform.position;
        pos.x -= playerSpeed * Time.deltaTime;
        transform.position = pos;
        if (Math.Abs(transform.position.x) > screenBounds.x * 2)
        {
            Destroy(this.gameObject);
        }
        
    }
}
