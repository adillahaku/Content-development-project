using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public Transform player;       // Referensi ke mobil
    public Transform pointer;      // Pointer arah
    public Transform titikA;       // Titik A
    public Transform titikB;       // Titik B
    public TextMeshProUGUI timerText; // UI Timer

    private float timer = 0f;      // Waktu berjalan
    private bool isTimerRunning = false; // Status timer

    void Start()
    {
        pointer.position = titikA.position;  // Awal arah ke Titik A
    }

    void Update()
    {
        if (isTimerRunning)
        {
            timer += Time.deltaTime;
            timerText.text = "Time: " + timer.ToString("F2") + "s";
        }
    }

    public void ReachTitikA()
    {
        Debug.Log("Reached Titik A");
        pointer.position = titikB.position;  // Pindahkan pointer ke Titik B
        StartTimer();  // Mulai Timer
    }

    public void ReachTitikB()
    {
        Debug.Log("Reached Titik B");
        StopTimer();  // Hentikan Timer
    }

    private void StartTimer()
    {
        timer = 0f;  // Reset Timer
        isTimerRunning = true;
    }

    private void StopTimer()
    {
        isTimerRunning = false;
        Debug.Log("Final Time: " + timer.ToString("F2") + "s");
    }
}
