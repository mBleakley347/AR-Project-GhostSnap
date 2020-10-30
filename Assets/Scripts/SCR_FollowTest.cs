using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class SCR_FollowTest : MonoBehaviour 
{
    public GameObject target;
    public float time;

    public bool found;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (found) transform.position = Vector3.MoveTowards(this.transform.position, target.transform.position, time);
    }

    public void OnFound()
    {
        found = true;
    }

    public void OnLost()
    {
        found = false;
    }
}
