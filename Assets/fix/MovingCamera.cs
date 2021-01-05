using UnityEngine;

public class MovingCamera : MonoBehaviour
{

    public float turnSpeed = 4.0f;
    public float panSpeed = 4.0f;
    public float zoomSpeed = 4.0f;

    private Vector3 mouseOrigin;
    private bool isPanning;
    private bool isRotating;
    private bool isZooming;

    void Start()
    {

    }
    public void Update()
    {
        if (Input.GetMouseButtonDown(0) || Input.GetMouseButtonDown(1) || Input.GetMouseButtonDown(2))
        {
            mouseOrigin = Input.mousePosition;
        }

        isRotating = Input.GetMouseButton(0);
        isPanning = Input.GetMouseButton(1);
        isZooming = Input.GetMouseButton(2);

        Vector3 pos = Camera.main.ScreenToViewportPoint(Input.mousePosition - mouseOrigin);
        if (isRotating)
        {
            transform.RotateAround(transform.position, transform.right, -pos.y * turnSpeed);
            transform.RotateAround(transform.position, Vector3.up, pos.x * turnSpeed);
        }

        if (isPanning)
        {
            Vector3 move = new Vector3(pos.x * panSpeed, pos.y * panSpeed, 0);
            transform.Translate(move, Space.Self);
        }

        if (isZooming)
        {
            Vector3 move = pos.y * zoomSpeed * transform.forward;
            transform.Translate(move, Space.World);
        }
    }
}