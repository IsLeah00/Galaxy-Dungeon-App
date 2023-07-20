using UnityEngine;

public class Dialogue : MonoBehaviour
{
    public GameObject BossDialog;


    void OnTriggerEnter2D(Collider2D Col)
    {
        if (Col.CompareTag("Player") || Col.CompareTag("Player1") || Col.CompareTag("Player2"))
        {
            BossDia();
            Destroy(BossDialog,4);
        }
    }

    private void BossDia()
    {
        BossDialog.SetActive(true);
    }
}
