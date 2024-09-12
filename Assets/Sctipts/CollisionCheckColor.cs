using UnityEngine;

public class ColorChecker : MonoBehaviour
{
    [SerializeField] Collider2D collider2DItem;
    [SerializeField] ChangeSpriteColor colorchanger;
    

    void OnTriggerStay2D(Collider2D other)
    {
        collider2DItem.enabled = false;
        Debug.Log("Alterado");
    }

    void OnTriggerExit2D(Collider2D other)
    {
         collider2DItem.enabled = true;
        colorchanger.CheckWallColors();
    }
}
