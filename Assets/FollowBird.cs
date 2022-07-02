using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowBird : MonoBehaviour
{
    public Transform Bird;
    public Vector3 offset;
    

    // Update is called once per frame
    void Update()
    {
        transform.position = Bird.position + offset;
    }
}
