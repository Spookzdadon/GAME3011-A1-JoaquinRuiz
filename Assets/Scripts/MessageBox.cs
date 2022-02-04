using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MessageBox : MonoBehaviour
{
    public Text messageBox;
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

    public void SetText(int id, string message)
    {
        if (id == 1)
        {
            StopAllCoroutines();
            StartCoroutine(messageTimer());
            messageBox.text = message;
        }
        else
        {
            messageBox.text = message;
        }
    }

    IEnumerator messageTimer()
    {
        yield return new WaitForSeconds(1);
        messageBox.text = "";
    }
}
