using UnityEngine;

public class ChangeSpriteColor : MonoBehaviour
{
    [SerializeField] SpriteRenderer spriteRenderer;
    [SerializeField] float changedAmount = 0.5f;
    private float changedAmountitem;
    private Color color;

    [SerializeField] Color[] colors = {
        new Color(1, 0, 0),   // Vermelho
        new Color(1, 1, 0),   // Amarelo
        new Color(0, 0, 1),   // Azul
        new Color(1, 0.5f, 0),// Laranja
        new Color(0, 1, 0),   // Verde
        new Color(0.5f, 0, 0.5f), // Roxo
        new Color(1, 1, 1)    // Branco
    };
    void Start()
    {
        color = spriteRenderer.color;
    }

    public void ChangeColorHardcoded(){

    }

    public void ChangeColor(float colorRGB)
    {
        if (color.r == 1f && color.g == 1f && color.b == 1f)
        {
            color.r = 0f;
            color.g = 0f;
            color.b = 0f;
        }
        if (colorRGB < 0){
            changedAmountitem = -changedAmount;
            colorRGB = - colorRGB;
        } else {
            changedAmountitem = changedAmount;
        }

        if (colorRGB == 1){
            color.r = Mathf.Clamp01(color.r + changedAmountitem);
            Debug.Log("Alterou a cor " + colorRGB + " em " + changedAmountitem);
        } else if (colorRGB == 2){
            color.g = Mathf.Clamp01(color.g + changedAmountitem);
            Debug.Log("Alterou a cor " + colorRGB + " em " + changedAmountitem);
        } else {
            color.b = Mathf.Clamp01(color.b + changedAmountitem);
            Debug.Log("Alterou a cor " + colorRGB + " em " + changedAmountitem);
        }
        spriteRenderer.color = color;
        RoundColor();
    }

    void Update()
    {
        switch (Input.inputString)
        {
            case "1":
                ChangeColor(1);
                RoundColor();
                break;
            case "2":
                ChangeColor(2);
                RoundColor();
                break;
            case "3":
                ChangeColor(3);
                RoundColor();
                break;
            case "4":
                ChangeColor(-1);
                RoundColor();
                break;
            case "5":
                ChangeColor(-2);
                RoundColor();
                break;
            case "6":
                ChangeColor(-3);
                RoundColor();
                break;
            default:
                break;
        }
    }

    private void RoundColor()
    {
        color.r = Mathf.Round(color.r * 10f) / 10f;
        color.g = Mathf.Round(color.g * 10f) / 10f;
        color.b = Mathf.Round(color.b * 10f) / 10f;
        spriteRenderer.color = color;
        CheckWallColors();
    }

    public void CheckWallColors()
    { 
        GameObject[] walls = GameObject.FindGameObjectsWithTag("ColorfullWall");
        foreach (GameObject wall in walls)
        {
            SpriteRenderer spriteRenderer = wall.GetComponent<SpriteRenderer>();
            if (spriteRenderer != null)
            {
                Collider2D collider2D = wall.GetComponent<Collider2D>();
                if (collider2D != null)
                {
                    if (spriteRenderer.color == color)
                    {
                        collider2D.enabled = false;
                        Debug.Log("Alterou para False");
                    }
                    else
                    {
                        collider2D.enabled = true;
                        Debug.Log("Alterou para True");
                    }
                }
            }
        }
    }
}