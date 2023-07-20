using UnityEngine;
using UnityEngine.SceneManagement;

public class SingleTeleport2 : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D Col)
    {
        if (Col.CompareTag("Player"))
        {
            SceneManager.LoadScene("Level2");
        }
    }
}
