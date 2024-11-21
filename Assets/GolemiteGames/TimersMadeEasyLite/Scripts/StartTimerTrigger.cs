using UnityEngine;

public class StartTimerTrigger : MonoBehaviour
{
    public Timer timer; // Hubungkan ke skrip Timer

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) // Jika mobil masuk
        {
            if (timer == null)
            {
                Debug.LogError("Timer is not assigned in the Inspector!");
                return;
            }

            Debug.Log("Starting timer...");
            timer.StartTimer(); // Mulai timer
        }
    }
}