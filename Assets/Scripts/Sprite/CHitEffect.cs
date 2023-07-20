using System.Collections;
using UnityEngine;

public class CHitEffect : MonoBehaviour
{
    public SpriteRenderer spriteRenderer = null;
    public Color flickerColor = Color.white;

    private Color startingColor = Color.clear;

    private void Start()
    {
        startingColor = spriteRenderer.color;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.CompareTag("Player1") || collision.transform.CompareTag("Player2"))
        {
            StartCoroutine(FlickerAnimation());
        }
    }

    IEnumerator FlickerAnimation()
    {
        spriteRenderer.color = flickerColor;

        yield return new WaitForSeconds(0.05f);

        spriteRenderer.color = startingColor;
    }
}
