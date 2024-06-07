using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCar : MonoBehaviour
{
    [SerializeField] private float carSpeedPerFrame;
    [SerializeField] private float carRotationPerFrame;
    [SerializeField] private float wheelRotationPerFrame;
    [SerializeField] private GameObject[] wheels;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void FixedUpdate()
    {
        Move();
        RotateWheels();
    }

    private void Move()
    {
        Quaternion nextRotation = Quaternion.Euler(transform.rotation.eulerAngles.x, transform.rotation.eulerAngles.y + carRotationPerFrame, transform.rotation.eulerAngles.z);

        float rotation = nextRotation.eulerAngles.y;
        float x = transform.position.x + (carSpeedPerFrame * Mathf.Sin(Mathf.Deg2Rad * rotation));
        float z = transform.position.z + (carSpeedPerFrame * Mathf.Cos(Mathf.Deg2Rad * rotation));
        Vector3 nextPos = new(x, transform.position.y, z);

        transform.SetPositionAndRotation(nextPos, nextRotation);
    }

    private void RotateWheels()
    {
        wheels[0].transform.Rotate(new Vector3(1, 0, 0), wheelRotationPerFrame);
        wheels[1].transform.Rotate(new Vector3(1, 0, 0), -wheelRotationPerFrame);
        wheels[2].transform.Rotate(new Vector3(1, 0, 0), wheelRotationPerFrame);
        wheels[3].transform.Rotate(new Vector3(1, 0, 0), -wheelRotationPerFrame);
    }
}
