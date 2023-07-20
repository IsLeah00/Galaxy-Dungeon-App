using UnityEngine;

public class HealthCollectible1 : MonoBehaviour
{
    [SerializeField] private float healthValue;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player1")
        {
            collision.GetComponent<Health1>().AddHealth(healthValue);
            gameObject.SetActive(false);
        }
    }
}
