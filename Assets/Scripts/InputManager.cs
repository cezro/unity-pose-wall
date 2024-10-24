using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    [SerializeField] private int defaultSpeed = 150;
    [SerializeField] private int defaultFrequency = 15;

    private int speed;
    private int frequency;

    public WallProperties wallProperties;
    public TMP_InputField speedInput;
    public TMP_InputField frequencyInput;
    void Start()
    {
        wallProperties.speed = defaultSpeed;
        wallProperties.frequency = defaultFrequency;
        speedInput.text = defaultSpeed.ToString();
        frequencyInput.text = defaultFrequency.ToString();

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SpeedInput()
    {
        int.TryParse(speedInput.text, out speed);
        wallProperties.speed = speed;

    }

    public void FrequencyInput()
    {
        int.TryParse(frequencyInput.text, out frequency);
        wallProperties.frequency = frequency;
    }
}
