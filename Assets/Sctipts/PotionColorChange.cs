using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    [SerializeField] ChangeSpriteColor changeSpriteColor;
    [SerializeField] float colorRGBchange123;
    [SerializeField] private Animator animator;
    [SerializeField] private ChangeWallsOnContact changeWallsOnContact;

    private void OnCollisionEnter2D(Collision2D collision) {

        if (colorRGBchange123 == 1) {
            animator.SetBool("isBlue",true);
            animator.SetBool("isYellow",false);
            animator.SetBool("isRed",false);
        }
        if (colorRGBchange123 == 2) {
            animator.SetBool("isBlue",false);
            animator.SetBool("isYellow",true);
            animator.SetBool("isRed",false);
        }
        if (colorRGBchange123 == 3) {
            animator.SetBool("isBlue",false);
            animator.SetBool("isYellow",false);
            animator.SetBool("isRed",true);
        }

        changeWallsOnContact.CheckWallColors();
        //changeSpriteColor.ChangeColor(colorRGBchange123);
        GetComponent<Collider2D>().enabled = false;
        Destroy(gameObject, 0.2f);
    }
}
