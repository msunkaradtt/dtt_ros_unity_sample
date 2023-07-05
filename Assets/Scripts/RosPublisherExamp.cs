using UnityEngine;
using Unity.Robotics.ROSTCPConnector;
using RosMessageTypes.RosUnityInterfaces;

public class RosPublisherExamp : MonoBehaviour
{
    ROSConnection rosConnection;
    public string topicName = "dtt_unity_pos_topic";

    public GameObject cube;
    public float publishMessageFrequency = 0.5f;

    private float timeElapsed;

    private void Start()
    {
        rosConnection = ROSConnection.GetOrCreateInstance();
        rosConnection.RegisterPublisher<PosMsg>(topicName);
    }

    private void Update()
    {
        timeElapsed += Time.deltaTime;

        if (timeElapsed > publishMessageFrequency)
        {
            cube.transform.rotation = Random.rotation;

            PosMsg cubePos = new(
                cube.transform.position.x,
                cube.transform.position.y,
                cube.transform.position.z);

            rosConnection.Publish(topicName, cubePos);

            timeElapsed = 0;
        }

    }
}
