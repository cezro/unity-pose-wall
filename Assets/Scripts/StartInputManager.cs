using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartInputManager : MonoBehaviour
{
    // Reference to the button
    public Button myButton;

    public void OnButtonClick()
    {
        myButton.gameObject.SetActive(false);
    }

    public void VisibleButton()
    {
        myButton.gameObject.SetActive(true);
    }
}
