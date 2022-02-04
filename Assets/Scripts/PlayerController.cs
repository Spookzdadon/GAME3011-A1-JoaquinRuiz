using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public GameObject miniGame, miniGameCanvas, gameCanvas;

    // Start is called before the first frame update
    void Start()
    {
        miniGame.SetActive(false);
        miniGameCanvas.SetActive(false);
    }

    public void StartGame()
    {
        gameCanvas.SetActive(false);
        miniGame.SetActive(true);
        miniGameCanvas.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
