using UnityEngine;
using UnityEngine.SceneManagement;

public class CTeleportHard2 : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D Col)
    {
        if (Col.CompareTag("Player1"))
        {
            SceneManager.LoadScene("CoopLevel2Hard");
        }

        if (Col.CompareTag("Player2"))
        {
            SceneManager.LoadScene("CoopLevel2Hard");
        }
    }
}
