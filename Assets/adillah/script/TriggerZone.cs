using UnityEngine;

public class TriggerZone : MonoBehaviour
{
    public GameManager gameManager;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (gameObject.name == "TitikA")
            {
                gameManager.ReachTitikA();
            }
            else if (gameObject.name == "TitikB")
            {
                gameManager.ReachTitikB();
            }
        }
    }
}
