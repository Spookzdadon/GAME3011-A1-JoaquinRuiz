using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    public enum Mode {Scan, Extract}

    public Mode currentMode;
    // Start is called before the first frame update
    void Start()
    {
        currentMode = Mode.Scan;
    }

    // Update is called once per frame
    void Update()
    {
        
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
}
