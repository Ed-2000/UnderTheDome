using UnityEngine;

public class XRotate : MonoBehaviour
{
    private float _minVerticalLimit = -90;
    private float _maxVerticalLimit = 45;

    private float _rotationX = 0;

    private void Update()
    {
        Rotate();
    }

    public void Rotate()
    {
        _rotationX -= Input.GetAxis("Mouse Y") * PlayerParameters.RotateSpeed;
        _rotationX = Mathf.Clamp(_rotationX, _minVerticalLimit, _maxVerticalLimit);

        float _rotationY = transform.localEulerAngles.y;
        float _rotationZ = transform.localEulerAngles.z;

        transform.localEulerAngles = new Vector3(_rotationX, _rotationY, _rotationZ);
    }
}