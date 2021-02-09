using UnityEngine;

public class PlayerParameters : MonoBehaviour
{
    [SerializeField] private float _speedRedactor = 5f;
    [SerializeField] private float _rotateSpeedRedactor = 3f;

    private static float _speed = 3.5f;
    private static float _rotateSpeed = 2f;
    private static int _numberOfMatches = 0;

    private void Start()
    {
        _speed = _speedRedactor;
        _rotateSpeed = _rotateSpeedRedactor;
    }

    public static float Speed { get => _speed; private set => _speed = value; }
    public static int NumberOfMatches { get => _numberOfMatches; set => _numberOfMatches = value; }
    public static float RotateSpeed { get => _rotateSpeed; set => _rotateSpeed = value; }
}