using UnityEngine;

public class SwordAnim : MonoBehaviour
{
    public Animator anim;

    private void Start()
    {
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Sword();
        }
    }

    void Sword()
    {
        anim.SetTrigger("Sword");
    }
}
