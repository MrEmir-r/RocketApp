using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSystem : MonoBehaviour
{
    public Transform rocketTransform;
    public Vector3 delay_p;
    public Vector4 delay_r;

    // Start is called before the first frame update
 
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        /*  this.transform.position = new Vector3(rocketTransform.position.x+delay_p.x, 1,
              rocketTransform.position.z+delay_p.z);

         this.transform.rotation = new Quaternion(rocketTransform.rotation.x+delay_r.x , rocketTransform.rotation.y + delay_r.y,
              rocketTransform.rotation.z + delay_r.z,delay_r.w);*/
        transform.position = delay_p;
        
    }
}
