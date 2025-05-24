using UnityEngine;

public class LaserPointer : MonoBehaviour
{
    public LineRenderer lineRenderer;
    public float maxDistance = 100f;

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
        lineRenderer.SetPosition(0, transform.position);
        lineRenderer.SetPosition(1, endPosition);
    }
}