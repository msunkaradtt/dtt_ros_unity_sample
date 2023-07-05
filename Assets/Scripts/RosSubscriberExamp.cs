using UnityEngine;
using Unity.Robotics.ROSTCPConnector;
using RosMessageTypes.RosUnityInterfaces;

public class RosSubscriberExamp : MonoBehaviour
{
    public GameObject cube;
    ROSConnection rosConnection;

    private void Start()
    {
        rosConnection = ROSConnection.GetOrCreateInstance();
        rosConnection.Subscribe<ColordttMsg>("dtt_ros_colorChange_topic", colorChange);
    }

    void colorChange(ColordttMsg colorMsg)
    {
        cube.GetComponent<Renderer>().material.color = new Color32((byte)colorMsg.r, (byte)colorMsg.g, (byte)colorMsg.b, (byte)colorMsg.a);
    }
}
