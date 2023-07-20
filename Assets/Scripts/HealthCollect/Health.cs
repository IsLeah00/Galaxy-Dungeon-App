using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField] private float startingHealth;
    public float currentHealth { get; private set; }
    private Animator anim;
    private bool dead;
    AudioSource audioSource;
    public GameObject GameOverUI;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    private void Awake()
    {
        currentHealth = startingHealth;
        anim = GetComponent<Animator>();
    }

    public void TakeDamage(float _damage)
    {
        currentHealth = Mathf.Clamp(currentHealth - _damage, 0, startingHealth);

        if (currentHealth > 0)
        {
            anim.SetTrigger("Hitted");
            GameOverOFF();
        }
        else
        {
            if (!dead)
            {
                anim.SetTrigger("Dead");
                GetComponent<PlayerMovement>().enabled = false;
                GetComponent<AudioSource>().enabled = false;
                dead = true;
                GameOverON();
            }
        }
    }

    public void AddHealth(float _value)
    {
        currentHealth = Mathf.Clamp(currentHealth + _value, 0, startingHealth);
    }

    public void GameOverON()
    {
        GameOverUI.SetActive(true);
        Time.timeScale = 0f;
    }

    public void GameOverOFF()
    {
        GameOverUI.SetActive(false);
        Time.timeScale = 1f;
    }
}
