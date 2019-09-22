using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundScroll : MonoBehaviour
{
    Material material;
    Vector2 offset;

    public float xVelocity, yVelocity;

    void Awake()
    {
        material = GetComponent<Renderer>().material;
    }

    void Update()
    {
        offset = new Vector2(xVelocity, yVelocity);
        material.mainTextureOffset += offset * Time.deltaTime;
    }
}
