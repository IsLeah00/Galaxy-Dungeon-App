using UnityEngine;
using UnityEngine.UI;

public class EnemyHealthbarHard : MonoBehaviour
{
    [SerializeField] private EnemyHealthHard henemyHealth;
    [SerializeField] private Image totalhealthBar;
    [SerializeField] private Image currenthealthBar;

    private void Start()
    {
        totalhealthBar.fillAmount = henemyHealth.currentHealth / 10;
    }
    private void Update()
    {
        currenthealthBar.fillAmount = henemyHealth.currentHealth / 10;
    }
}
