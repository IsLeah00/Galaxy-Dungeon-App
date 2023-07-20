using UnityEngine;

public class HealthCollectible2 : MonoBehaviour
{
    [SerializeField] private float healthValue;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player2")
        {
            collision.GetComponent<Health2>().AddHealth(healthValue);
            gameObject.SetActive(false);
        }
    }
}
