using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class World_Hub_Icon : MonoBehaviour
{
    public Collider2D icon_collider;

    public string level;

    void Start()
    {
        icon_collider = GetComponent<Collider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(Camera.main.transform.position, Vector3.up);
    }
}
