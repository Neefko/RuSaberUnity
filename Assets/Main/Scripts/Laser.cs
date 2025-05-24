using UnityEngine;

public class LaserPointer : MonoBehaviour
{
    public LineRenderer lineRenderer;
    public float maxDistance = 100f;

    void Update()
    {
        // ������ ��� �� ������� ������� �����
        Ray ray = new Ray(transform.position, transform.forward);
        RaycastHit hit;

        // �� ��������� � ������������ �����
        Vector3 endPosition = ray.origin + ray.direction * maxDistance;

        if (Physics.Raycast(ray, out hit, maxDistance))
        {
            endPosition = hit.point;

            // �������������: ����� ������������ ������
            // Debug.DrawRay(ray.origin, ray.direction * hit.distance, Color.green);
        }

        // ��������� ����� LineRenderer
        lineRenderer.SetPosition(0, transform.position);
        lineRenderer.SetPosition(1, endPosition);
    }
}