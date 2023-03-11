using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController1 : MonoBehaviour
{

    public CarControllers target;
    private Vector3 offsetDir;

    public float minDistance, maxDistance;
    private float activeDistance;

    // Start is called before the first frame update
    void Start()
    {
        offsetDir = transform.position - target.transform.position;

        activeDistance = minDistance;

        offsetDir.Normalize();
    }

    // Update is called once per frame
    void Update()
    {
        activeDistance = minDistance + ((maxDistance - minDistance) * (target.RB.velocity.magnitude / target.maxSpeed));

        transform.position = target.transform.position + (offsetDir * activeDistance);
    }
}
