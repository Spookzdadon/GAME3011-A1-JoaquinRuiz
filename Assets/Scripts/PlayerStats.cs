using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerStats : MonoBehaviour
{
    public enum Mode {Scan, Extract}
    public Mode currentMode;
    public Text resourceText;

    private int resources = 0;
    // Start is called before the first frame update
    void Start()
    {
        currentMode = Mode.Scan;
    }

    // Update is called once per frame
    void Update()
    {
        resourceText.text = resources.ToString();
    }

    public void ToggleMode()
    {
        if (currentMode == Mode.Extract)
        {
            currentMode = Mode.Scan;
        }
        else if (currentMode == Mode.Scan)
        {
            currentMode = Mode.Extract;
        }
    }

    public void AddResources(int amount)
    {
        resources += amount;
    }
    public int GetResources()
    {
        return resources;
    }
}
