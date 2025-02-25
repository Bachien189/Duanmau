using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target; // Nhân vật cần theo dõi
    public Vector3 offset; // Độ lệch giữa camera và nhân vật

    void Update()
    {
        if (target == null) return;

        // Cập nhật vị trí camera đúng theo nhân vật
        transform.position = target.position + offset;
    }
}
