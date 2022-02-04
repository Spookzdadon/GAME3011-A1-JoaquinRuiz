using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResourceTileScript : MonoBehaviour
{
    public enum TileType { Max, Half, Quarter, None }
    public TileType currentTileType;
    PlayerStats playerStats;
    MessageBox messageBox;
    private int resourceGiven;
    // Start is called before the first frame update
    void Start()
    {
        playerStats = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerStats>();
        messageBox = GameObject.FindGameObjectWithTag("MessageBox").GetComponent<MessageBox>();

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
        if (playerStats.currentMode == PlayerStats.Mode.Extract && playerStats.extracts > 0)
        {
            playerStats.AddResources(resourceGiven);
            playerStats.extracts -= 1;
            Destroy(gameObject);
        }
        
        else if (playerStats.currentMode == PlayerStats.Mode.Extract && playerStats.extracts <= 0)
        {
            messageBox.SetText(0, "You have used all your extracts! You have mined a total of " + playerStats.resources + " resources!");
        }
    }
}
