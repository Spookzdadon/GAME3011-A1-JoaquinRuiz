using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScanTile : MonoBehaviour
{
    public List<GameObject> neighbours = new List<GameObject>();
    public CircleCollider2D circleCollider;
    public BoxCollider2D boxCollider;
    PlayerStats playerStats;
    MessageBox messageBox;

    // Start is called before the first frame update
    void Start()
    {
        playerStats = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerStats>();
        messageBox = GameObject.FindGameObjectWithTag("MessageBox").GetComponent<MessageBox>();
        FindNeighbours();
    }

    // Update is called once per frame
    void Update()
    {
        if (playerStats.currentMode != PlayerStats.Mode.Scan)
        {
            boxCollider.enabled = false;
            circleCollider.enabled = false;
        }

        else if (playerStats.currentMode != PlayerStats.Mode.Extract)
        {
            boxCollider.enabled = true;
            circleCollider.enabled = true;
        }
    }

    private void OnMouseDown()
    {
        if (playerStats.currentMode == PlayerStats.Mode.Scan && playerStats.scans > 0)
        {
            playerStats.scans -= 1;

            foreach (GameObject tile in neighbours)
            {
                Destroy(tile.gameObject);
            }
            Destroy(gameObject);
        }

        else if (playerStats.currentMode == PlayerStats.Mode.Scan && playerStats.scans <= 0)
        {
            messageBox.SetText(1, "You have no more scans!");
        }
    }

    void FindNeighbours()
    {
        ScanTile[] tiles = FindObjectsOfType<ScanTile>();

        foreach (ScanTile tile in tiles)
        {
            if (tile.gameObject.GetInstanceID() != gameObject.GetInstanceID())
            {
                if (circleCollider.bounds.Intersects (tile.gameObject.GetComponent<Collider2D>().bounds))
                {
                    Debug.Log("[" + gameObject.name + "] found a neighbour: " + tile.gameObject.name);
                    neighbours.Add(tile.gameObject);
                }
            }
        }
    }
}
