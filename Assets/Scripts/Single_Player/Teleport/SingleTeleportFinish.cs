using UnityEngine;
using UnityEngine.SceneManagement;

public class SingleTeleportFinish : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D Col)
    {
        if (Col.CompareTag("Player"))
        {
            SceneManager.LoadScene("End");
        }
    }
}
