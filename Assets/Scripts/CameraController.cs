using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public static CameraController instance;

    public Transform target;

    public float minHeight, maxHeight;

    private Vector2 lastPos;

    public bool stopFollow;

    private void Awake()
    {
        instance = this;
    }

    void Start()
    {
        lastPos = transform.position;
    }


    void Update()
    {
        if (!stopFollow)
        {
            transform.position = new Vector3(target.position.x, Mathf.Clamp(target.position.y, minHeight, maxHeight), transform.position.z);

            Vector2 amountToMove = new Vector2(transform.position.x - lastPos.x, transform.position.y - lastPos.y);

            lastPos = transform.position;
        }

    }
}
