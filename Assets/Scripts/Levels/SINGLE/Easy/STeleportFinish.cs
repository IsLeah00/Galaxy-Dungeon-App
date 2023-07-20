using UnityEngine;
using UnityEngine.SceneManagement;

public class STeleportFinish : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D Col)
    {
        if (Col.CompareTag("Player"))
        {
            SceneManager.LoadScene("End");
        }
    }
}
