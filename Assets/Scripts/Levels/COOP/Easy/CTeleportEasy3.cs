using UnityEngine;
using UnityEngine.SceneManagement;

public class CTeleportEasy3 : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D Col)
    {
        if (Col.CompareTag("Player1"))
        {
            SceneManager.LoadScene("CoopLevel3Easy");
        }

        if (Col.CompareTag("Player2"))
        {
            SceneManager.LoadScene("CoopLevel3Easy");
        }
    }
}
