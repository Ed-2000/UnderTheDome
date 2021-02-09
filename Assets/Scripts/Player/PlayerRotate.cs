using UnityEngine;

public class PlayerRotate : MonoBehaviour
{
    private void Start()
    {
        Rigidbody rb = GetComponent<Rigidbody>();

        if (rb  != null)
        {
            rb.freezeRotation = true;
        }
    }

    private void Update()
    {
        Rotate();
    }

    public void Rotate()
    {
        float _rotationX = transform.localEulerAngles.x;
        float _rotationY = transform.localEulerAngles.y + Input.GetAxis("Mouse X") * PlayerParameters.RotateSpeed;

        transform.localEulerAngles = new Vector3(_rotationX, _rotationY, 0);
    }
}