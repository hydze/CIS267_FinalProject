using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class HomingProjectile : MonoBehaviour
{
    private Transform target;
    private Rigidbody2D rb;
    public float speed;
    public float rotateSpeed;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        setTarget();
    }

    private void FixedUpdate()
    {
        Vector2 direction = (Vector2)target.position - rb.position;

        direction.Normalize();

        float rotateAmt = Vector3.Cross(direction, transform.up).z;

        rb.angularVelocity = -rotateAmt * rotateSpeed;

        rb.velocity = transform.up * speed;
    }

    void setTarget()
    {
        target = GameManager.instance.getTarget_l3();
    }
}
 