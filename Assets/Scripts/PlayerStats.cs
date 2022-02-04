using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerStats : MonoBehaviour
{
    public enum Mode {Scan, Extract}
    public Mode currentMode;
    public Text resourceText;
    public Text modeText;
    public Text scanText;
    public Text extractText;
    public int scans = 6;
    public int extracts = 3;
    public int resources = 0;

    // Start is called before the first frame update
    void Start()
    {
        currentMode = Mode.Extract;
    }

    // Update is called once per frame
    void Update()
    {
        resourceText.text = resources.ToString();
        scanText.text = scans.ToString();
        extractText.text = extracts.ToString();
    }

    public void ToggleMode()
    {
        if (currentMode == Mode.Extract)
        {
            currentMode = Mode.Scan;
            modeText.text = "Scan";
        }
        else if (currentMode == Mode.Scan)
        {
            currentMode = Mode.Extract;
            modeText.text = "Extract";
        }
    }

    public void AddResources(int amount)
    {
        resources += amount;
    }
}
