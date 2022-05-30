using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CharController : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI text;
    [SerializeField] char currentChar;
    [SerializeField] Button button;

    private void Start()
    {
        button.onClick.AddListener(() => OnPressButton());
    }

    public void UpdateText(char value)
    {
        text.text = value.ToString();
        currentChar = value;
    }

    public void OnPressButton()
    {
        //Send current char
        //GamePlayController.Instance.OnPressHandle(currentChar);
    }
}
