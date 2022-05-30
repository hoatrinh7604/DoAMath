using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CircleController : MonoBehaviour
{
    [SerializeField] Image color;
    [SerializeField] Button button;
    private int colorIndex;

    private void Start()
    {
        button.onClick.AddListener(() => Press());
    }

    public void SetColorIndex(int value)
    {
        colorIndex = value;
        UpdateColor();
    }

    public int GetColorIndex()
    {
        return colorIndex;
    }

    public void UpdateColor()
    {
        color.color = GamePlayController.Instance.template[colorIndex];
    }

    public void Press()
    {
        Destroy(this.gameObject, 0.05f);
    }

    public void RandomColor()
    {
        SetColorIndex(Random.Range(0, GamePlayController.Instance.template.Length));
    }
}
