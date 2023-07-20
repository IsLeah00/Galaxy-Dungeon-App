using UnityEngine;
using UnityEngine.SceneManagement;

public class CTeleportEasy2 : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D Col)
    {
        if (Col.CompareTag("Player1"))
        {
            SceneManager.LoadScene("CoopLevel2Easy");
        }

        if (Col.CompareTag("Player2"))
        {
            SceneManager.LoadScene("CoopLevel2Easy");
        }
    }
}
