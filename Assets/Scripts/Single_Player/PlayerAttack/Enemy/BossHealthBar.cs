using UnityEngine;
using UnityEngine.UI;

public class BossHealthBar : MonoBehaviour
{
    [SerializeField] private BossHealth bossHealth;
    [SerializeField] private Image totalhealthBar;
    [SerializeField] private Image currenthealthBar;

    private void Start()
    {
        totalhealthBar.fillAmount = bossHealth.currentHealth / 10;
    }
    private void Update()
    {
        currenthealthBar.fillAmount = bossHealth.currentHealth / 10;
    }
}
