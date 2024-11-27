using UnityEngine;
using TMPro;

public class TimerController : MonoBehaviour
{
    public TextMeshProUGUI timerText;  // Referensi ke UI Text
    private float currentTime = 0f;    // Waktu berjalan
    private bool isTimerRunning = false; // Apakah timer aktif?

    void Update()
    {
        if (isTimerRunning)
        {
            currentTime += Time.deltaTime;  // Tambahkan waktu setiap frame
            timerText.text = "Time: " + currentTime.ToString("F2") + "s"; // Update UI
        }
    }

    public void StartTimer()
    {
        isTimerRunning = true;
        currentTime = 0f;  // Reset timer
    }

    public void StopTimer()
    {
        isTimerRunning = false;
        Debug.Log("Timer Stopped. Final Time: " + currentTime.ToString("F2") + "s");
    }
}
