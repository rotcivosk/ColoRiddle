using UnityEngine;

public class SwitchController : MonoBehaviour
{
    [SerializeField] private Sprite onSprite;
    [SerializeField] private Sprite offSprite;
    [SerializeField] private SpriteRenderer switchSpriteRenderer;
    [SerializeField] private GameObject exit;
    [SerializeField] private Collider2D switchCollider;

    private Animator saidaAnimator;
    private Collider2D saidaCollider;
    private SpriteRenderer saidaSpriteRenderer;

    void Start()
    {
        // Obtém os componentes necessários do objeto "Saída"
        saidaAnimator = exit.GetComponent<Animator>();
        saidaCollider = exit.GetComponent<Collider2D>();
        saidaSpriteRenderer = exit.GetComponent<SpriteRenderer>();
    }

    void OnTriggerStay2D(Collider2D other)
    {
        switchSpriteRenderer.sprite = onSprite;
        if (saidaAnimator != null)
        {
            saidaAnimator.enabled = true;
        }
        if (saidaCollider != null)
        {
            saidaCollider.enabled = true;
        }
        if (switchCollider != null)
        {
            switchCollider.enabled = false;
        }
    }
}