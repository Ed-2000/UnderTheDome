using UnityEngine;

public class GravityRoom : MonoBehaviour
{
    public static float GravityForce { get => _gravityForce; set => _gravityForce = value; }

    [SerializeField] private float _gravityForceRedactor;
    private static float _gravityForce;

    private void Update()
    {
        _gravityForce = _gravityForceRedactor;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<Rigidbody>() != null && other.GetComponent<SubmissiveToGravity>() == null)
        {
            other.gameObject.AddComponent<SubmissiveToGravity>();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.GetComponent<SubmissiveToGravity>() != null)
        {
            SubmissiveToGravity submessiveToGravity = other.GetComponent<SubmissiveToGravity>();
            Destroy(submessiveToGravity);
        }
    }
}