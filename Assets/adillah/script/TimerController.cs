using UnityEngine;
using TMPro;

public class DeliveryTimer : MonoBehaviour
{
    public float timeLimit = 60f;  // Batas waktu dalam detik
    private float currentTime;
    public TextMeshProUGUI timerText;  // Referensi ke UI Text

    private bool isTimerRunning = false;

    void Start()
    {
        currentTime = timeLimit;
    }

    void Update()
    {
        if (isTimerRunning)
        {
            currentTime -= Time.deltaTime;
            timerText.text = "Time Left: " + Mathf.Ceil(currentTime) + "s";

            if (currentTime <= 0)
            {
                isTimerRunning = false;
                Debug.Log("Time's up!");
                // Logika untuk waktu habis
            }
        }
    }

    public void StartTimer()
    {
        currentTime = timeLimit;
        isTimerRunning = true;
    }
}
