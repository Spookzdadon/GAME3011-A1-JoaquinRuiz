using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResourceTileScript : MonoBehaviour
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

    private void OnMouseDown()
    {
        if (playerStats.currentMode == PlayerStats.Mode.Extract)
        {
            Destroy(gameObject);
        }
    }
}
