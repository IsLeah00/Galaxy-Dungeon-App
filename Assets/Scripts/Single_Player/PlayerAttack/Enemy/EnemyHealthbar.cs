using UnityEngine;
using UnityEngine.UI;

public class EnemyHealthbar : MonoBehaviour
{
    [SerializeField] private EnemyHealth enemyHealth;
    [SerializeField] private Image totalhealthBar;
    [SerializeField] private Image currenthealthBar;

    private void Start()
    {
        totalhealthBar.fillAmount = enemyHealth.currentHealth / 10;
    }
    private void Update()
    {
        currenthealthBar.fillAmount = enemyHealth.currentHealth / 10;
    }
}
