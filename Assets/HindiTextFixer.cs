using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HindiTextFixer : MonoBehaviour
{
    [SerializeField] Text hindiText;
    [SerializeField] InputField hindiTextInput;

    void Update()
    {
        hindiText.text = UnicodeToKrutidev.UnicodeToKrutiDev(hindiTextInput.text);
    }


}
