using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    private CharacterController _chController;
    private float _gravityForce = -9.8f;
    private float _hor;
    private float _vert;
    
    private void Start()
    {
        _chController = GetComponent<CharacterController>();
    }

    private void Update()
    {
        Move();
    }

    //движение
    public void Move()
    {
        _hor = Input.GetAxis("Horizontal");
        _vert = Input.GetAxis("Vertical");

        Vector3 moveVector = new Vector3(_hor, 0, _vert);
        moveVector = moveVector.normalized * PlayerParameters.Speed;

        moveVector.y = _gravityForce;

        moveVector *= Time.deltaTime;
        moveVector = transform.TransformDirection(moveVector);

        _chController.Move(moveVector);
    }
}