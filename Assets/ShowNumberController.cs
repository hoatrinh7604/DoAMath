using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ShowNumberController : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI numberText;
    [SerializeField] string character = "";

    private void Start()
    {
        character = "";
        numberText.text = "";
    }

    public void SetInfo(string value)
    {
        numberText.text = value;
        character = value;
    }
}
