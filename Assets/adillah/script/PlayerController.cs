using UnityEngine;
using UnityEngine.AI;

public class PlayerController : MonoBehaviour
{
    public Transform pickupPoint;
    private NavMeshAgent agent;

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        SetDestination(pickupPoint);
    }

    void SetDestination(Transform destination)
    {
        agent.SetDestination(destination.position);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == pickupPoint.gameObject)
        {
            Debug.Log("Sampai di titik penjemputan!");
            // Lakukan aksi penjemputan di sini
        }
    }
}
