using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class HindiTextFixer : MonoBehaviour
{
    [SerializeField] Text hindiText;
    [SerializeField] InputField hindiTextInput;

    [SerializeField] TMP_Text hindiTMPText;
    [SerializeField] TMP_InputField hindiTMPTextInput;

    void Update()
    {
        if (hindiText && hindiTextInput) hindiText.text = UnicodeToKrutidev.UnicodeToKrutiDev(hindiTextInput.text);
        //if (hindiText && hindiTextInput) hindiText.text = hindiTextInput.text;
    }
}
