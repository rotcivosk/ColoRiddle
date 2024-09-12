using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;
using UnityEngine.Tilemaps;

public class ChangeWallsOnContact : MonoBehaviour
{

    [SerializeField] private TilemapCollider2D yellowWall;
    [SerializeField] private TilemapCollider2D redWall;
    [SerializeField] private TilemapCollider2D blueWall;
    [SerializeField] private Animator animator;

    private bool isRed;
    private bool isYellow;
    private bool isblue;
    



    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
    }
    
    public void CheckWallColors()
    { 
        
        isRed = animator.GetBool("isRed");


        if (isblue == true){

            blueWall.gameObject.SetActive(false);
            redWall.gameObject.SetActive( true);
            yellowWall.gameObject.SetActive (true);
            Debug.Log("Desativou o tileSet Azul");
        }

        if (isRed == true){

            blueWall.gameObject.SetActive(true);
            redWall.gameObject.SetActive( false);
            yellowWall.gameObject.SetActive (true);
            Debug.Log("Desativou o tileSet Azul");
        }

        if (isYellow == true){

            blueWall.enabled = false;
            redWall.enabled = false;
            yellowWall.enabled = true;
            Debug.Log("Desativou o tileset Amarelo");
        }
    }


}
