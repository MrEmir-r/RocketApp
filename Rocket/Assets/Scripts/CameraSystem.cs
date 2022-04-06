using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSystem : MonoBehaviour
{
    public Transform rocketTransform;
    public Vector3 delay;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.position = new Vector3(rocketTransform.position.x+delay.x, rocketTransform.position.y+delay.y,
            rocketTransform.position.z+delay.z);
    }
}
