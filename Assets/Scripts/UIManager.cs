using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UIManager : MonoBehaviour
{
    public Slider characterHealthSlider;
    public TextMeshProUGUI interactionText;

    public void UpdateCharacterHealthSlider(float health)
    {
        characterHealthSlider.value = health;     
    }

    public void ShowInteractionText()
    {
        interactionText.text = "press E to interact";
    }

    public void HideInteractionText()
    {
        interactionText.text = "";
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
