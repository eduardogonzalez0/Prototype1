using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    
    public GameObject player;
    private Vector3 Offset
    void Update()
    {
        transform.position = player.transform.position + new Vector3(0, 5, -7);
    }
}
