using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchButtonBehaviour : MonoBehaviour
{
    PlayerStats playerStats;

    // Start is called before the first frame update
    void Start()
    {
        playerStats = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerStats>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnButtonClicked()
    {
        playerStats.ToggleMode();
    }
}
