using UnityEngine;

public class CameraManager : MonoBehaviour
{
    public Camera camera1;
    public Camera camera2;
    public KeyCode switchKey = KeyCode.Alpha1;
    public KeyCode switchKey2 = KeyCode.Alpha2;

    void Start()
    {
        camera1.enabled = true;
        camera2.enabled = false;
    }

    void Update()
    {
        if (Input.GetKeyDown(switchKey))
        {
            camera1.enabled = true;
            camera2.enabled = false;
        } else if(Input.GetKeyDown(switchKey2))
        {
            camera1.enabled = false;
            camera2.enabled = true;
        }
    }
}
