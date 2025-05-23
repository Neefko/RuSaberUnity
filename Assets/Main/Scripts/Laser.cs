using UnityEngine;

[RequireComponent(typeof(LineRenderer))]
public class LaserPointer : MonoBehaviour
{
    public LineRenderer lineRenderer;
    public float maxDistance = 100f;

    void Awake()
    {
        if (lineRenderer == null)
            lineRenderer = GetComponent<LineRenderer>();

        lineRenderer.startWidth = 0.01f;
        lineRenderer.endWidth = 0.01f;
    }

    void Update()
    {
        Ray ray = new Ray(transform.position, transform.forward);
        Vector3 endPosition = ray.origin + ray.direction * maxDistance;

        if (Physics.Raycast(ray, out RaycastHit hit, maxDistance))
        {
            endPosition = hit.point;
        }

        lineRenderer.SetPosition(0, transform.position);
        lineRenderer.SetPosition(1, endPosition);
    }
}