using UnityEngine;

public class PointerController : MonoBehaviour
{
    public Transform target;  // Titik tujuan (misalnya TitikA atau TitikB)
    public Transform player;  // Posisi pemain

    void Update()
    {
        if (target != null && player != null)
        {
            Vector3 direction = target.position - player.position;
            float angle = Mathf.Atan2(direction.z, direction.x) * Mathf.Rad2Deg;
            transform.rotation = Quaternion.Euler(new Vector3(0, -angle, 0));
        }
    }
}
