using UnityEngine;
using UnityEngine.SceneManagement;

public class TeleportFinish : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D Col)
    {
        if (Col.CompareTag("Player1"))
        {
            SceneManager.LoadScene("End");
        }

        if (Col.CompareTag("Player2"))
        {
            SceneManager.LoadScene("End");
        }
    }
}
