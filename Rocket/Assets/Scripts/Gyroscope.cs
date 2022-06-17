using UnityEngine;
using System.IO.Ports;

public class Gyroscope : MonoBehaviour
{
    //public GameObject rocket;
    SerialPort stream = new SerialPort("COM11", 115200);
    public string strReceived;
    public Vector4 delay;
    public string[] strData = new string[4];
    public string[] strData_received = new string[4];
    public float qw, qx, qy, qz;
    private void Start()
    {
        stream.Open();
        if (SystemInfo.supportsGyroscope)
        {
            Input.gyro.enabled = true;
        }
    }

    // Update is called once per frame
    void Update()
    {
        /*if (SystemInfo.supportsGyroscope)
            rocket.transform.rotation = GyroToUnity(Input.gyro.attitude);*/


        strReceived = stream.ReadLine(); //Read the information  
        transform.position = Vector3.one;
        strData = strReceived.Split(',');
        if (strData[0] != "" && strData[1] != "" && strData[2] != "" && strData[3] != "")//make sure data are reday
        {
            strData_received[0] = strData[0];
            strData_received[1] = strData[1];
            strData_received[2] = strData[2];
            strData_received[3] = strData[3];

            qw = float.Parse(strData_received[0]);
            qx = float.Parse(strData_received[1]);
            qy = float.Parse(strData_received[2]);
            qz = float.Parse(strData_received[3]);

             transform.rotation = new Quaternion(qx+delay.x, qy + delay.y, qz+delay.z, qw+delay.w);
           // transform.rotation = new Quaternion(delay.x, delay.y ,delay.z, delay.w);

        }
    }

    /*on GyroToUnity(Quaternion q)
    {
        return new Quaternion(q.x, q.y,-q.z,-q.w);
    }*/
}
