using UnityEngine;

public class StartTimerOnCollision : MonoBehaviour
{
    public Timer timerScript; // Referensi ke skrip Timer

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("TargetCube")) // Pastikan objek lain memiliki tag "TargetCube"
        {
            timerScript.StartTimer(); // Panggil metode untuk memulai timer
        }
    }
}
