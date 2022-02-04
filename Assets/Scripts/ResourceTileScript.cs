using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResourceTileScript : MonoBehaviour
{
    public enum TileType { Max, Half, Quarter, None }
    public TileType currentTileType;
    PlayerStats playerStats;
    private int resourceGiven;
    // Start is called before the first frame update
    void Start()
    {
        playerStats = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerStats>();
        switch (currentTileType)
        {
            case TileType.Max:
                resourceGiven = 10;
                break;
            case TileType.Half:
                resourceGiven = 5;
                break;
            case TileType.Quarter:
                resourceGiven = 2;
                break;
            case TileType.None:
                resourceGiven = 0;
                break;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        if (playerStats.currentMode == PlayerStats.Mode.Extract)
        {
            playerStats.AddResources(resourceGiven);
            Destroy(gameObject);
        }
    }
}
