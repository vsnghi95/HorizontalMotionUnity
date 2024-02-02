using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallForce : MonoBehaviour
{
    public float horizontalForceMultiplier; // Điều chỉnh lực nằm ngang
    public float verticalForceMultiplier = 5f; // Điều chỉnh lực đứng lên do trọng lực
    public float heightAboveGround = 2f; // Độ cao so với mặt đất
    public float angularDragFactor = 1f;

    void Start()
    {
        
    }

    void Update()
    {
        // Kiểm tra sự kiện hoặc điều kiện nào đó để tác động lực
        
            
        
    }

    public void ApplyHorizontalForce()
    {
        Rigidbody rb = GetComponent<Rigidbody>();

        if (rb != null)
        {
            // Tạo vector lực nằm ngang
            Vector3 horizontalForce = new Vector3(horizontalForceMultiplier, 0, 0);

            // Tác động lực nằm ngang vào Rigidbody
            rb.AddForce(horizontalForce, ForceMode.Impulse);
        }
    }

    public void ApplyVerticalForce()
    {
        Rigidbody rb = GetComponent<Rigidbody>();

        if (rb != null)
        {
            // Tạo vector lực đứng lên do trọng lực
            Vector3 verticalForce = new Vector3(0, verticalForceMultiplier, 0);

            // Tác động lực đứng lên vào Rigidbody
            rb.AddForce(verticalForce, ForceMode.Impulse);
        }
    }

    public void SetInitialValues(float velocity)
    {
        horizontalForceMultiplier = velocity;
        //heightAboveGround = height;
    }

    void FixedUpdate()
    {
        ApplyAngularDrag();
    }

    void ApplyAngularDrag()
    {
        Rigidbody rb = GetComponent<Rigidbody>();

        if (rb != null)
        {
            // Apply angular drag to simulate air resistance and stop rolling
            rb.angularDrag = angularDragFactor;
        }
    }
}
