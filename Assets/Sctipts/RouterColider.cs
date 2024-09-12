using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RouterColider : MonoBehaviour
{
    [SerializeField] GameController gameController;
    // Start is called before the first frame update
    void OnTriggerStay2D(Collider2D other)
    {
        gameController.TriggerEndGame();
    }
}
