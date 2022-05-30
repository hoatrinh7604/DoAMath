using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AnimalController : MonoBehaviour
{
    [SerializeField] int id;

    private Button button;

    // Start is called before the first frame update
    void Start()
    {
        button = GetComponent<Button>();
        button.onClick.AddListener(() => OnPressButton());
    }

    public void OnPressButton()
    {
        gameObject.SetActive(false);
    }

    public int GetID()
    {
        return id;
    }
}
