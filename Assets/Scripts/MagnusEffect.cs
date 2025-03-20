using UnityEngine;

public class MagnusEffect : MonoBehaviour
{
    public Vector3 velocity; // ความเร็วของลูกบอล
    public Vector3 spin; // การหมุนของลูกบอล
    public float magnusCoefficient = 0.1f; // ค่าคงที่ของ Magnus Effect

    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.linearVelocity = velocity; // กำหนดความเร็วเริ่มต้น
    }

    void FixedUpdate()
    {
        // คำนวณแรง Magnus Effect
        Vector3 magnusForce = magnusCoefficient * Vector3.Cross(spin, rb.linearVelocity);
        rb.AddForce(magnusForce, ForceMode.Force);
    }
}