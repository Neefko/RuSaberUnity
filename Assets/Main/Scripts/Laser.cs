using UnityEngine;

<<<<<<< HEAD
=======
[RequireComponent(typeof(LineRenderer))]
>>>>>>> 84970d7cd02d938a18b11a72800fed902e8bc712
public class LaserPointer : MonoBehaviour
{
    public LineRenderer lineRenderer;
    public float maxDistance = 100f;

<<<<<<< HEAD
    void Update()
    {
        // Создаём луч из позиции объекта вперёд
        Ray ray = new Ray(transform.position, transform.forward);
        RaycastHit hit;

        // По умолчанию — максимальная длина
        Vector3 endPosition = ray.origin + ray.direction * maxDistance;

        if (Physics.Raycast(ray, out hit, maxDistance))
        {
            endPosition = hit.point;

            // Дополнительно: можно подсвечивать объект
            // Debug.DrawRay(ray.origin, ray.direction * hit.distance, Color.green);
        }

        // Установка точек LineRenderer
=======
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

>>>>>>> 84970d7cd02d938a18b11a72800fed902e8bc712
        lineRenderer.SetPosition(0, transform.position);
        lineRenderer.SetPosition(1, endPosition);
    }
}