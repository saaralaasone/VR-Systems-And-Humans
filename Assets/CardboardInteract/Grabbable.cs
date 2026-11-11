using UnityEngine;

public class Grabbable : Interactive
{
    [SerializeField] float grabSpeed = 5f;
    public bool useGravity = true;
    static Transform grabbed = null;
    static Transform cam = null;
    Rigidbody rb;
    float grabDistance = 0f;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    public new void Interact()
    {
        if (grabbed != transform)
        {
            grabbed = transform;
            grabDistance = Vector3.Distance(cam.position, transform.position);
        }
        else
            grabbed = null;
    }

    void Update()
    {
        if (!cam && Camera.main)
            cam = Camera.main.transform;

        rb.useGravity = grabbed != transform && useGravity;

        if (grabbed == transform)
        {
            Vector3 targetPoint = cam.position + cam.forward * grabDistance;
            rb.linearVelocity = (targetPoint - transform.position) * grabSpeed;
        }
    }
}
