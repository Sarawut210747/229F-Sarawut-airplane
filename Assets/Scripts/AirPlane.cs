using UnityEngine;
using UnityEngine.InputSystem;
public class AirPlane : MonoBehaviour
{
    [SerializeField] Rigidbody rb;
    [SerializeField] float enginePower;
    [SerializeField] float liftBosster;
    [SerializeField] float drag;
    [SerializeField] float anglarDrag;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    private void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            rb.AddForce(transform.forward * enginePower);
            
        }
        Vector3 lift = Vector3.Project(rb.linearVelocity, transform.forward);
        rb.AddForce(transform.up * lift.magnitude * liftBosster);
    }

}
