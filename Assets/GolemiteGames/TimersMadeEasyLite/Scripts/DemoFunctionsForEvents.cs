using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DemoFunctionsForEvents : MonoBehaviour
{
    public GameObject finishedText; // Teks yang muncul saat timer selesai
    public Timer timer; // Referensi ke skrip Timer
    
    // Fungsi ini dipanggil saat timer dimulai
    public void TimerStart()
    {
        // Menyembunyikan teks yang menandakan timer telah selesai
        finishedText.SetActive(false);
        
        // Memulai timer
        timer.StartTimer();
    }

    // Fungsi ini dipanggil saat timer berakhir
    public void TimerEnd()
    {
        // Menampilkan teks yang menandakan timer telah selesai
        finishedText.SetActive(true);
    }

}
