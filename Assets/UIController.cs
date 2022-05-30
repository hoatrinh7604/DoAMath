using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UIController : MonoBehaviour
{
    [SerializeField] GameObject gameOver;
    [SerializeField] GameObject confirm;
    [SerializeField] TextMeshProUGUI score;
    [SerializeField] TextMeshProUGUI highscore;

    [SerializeField] GameObject slider;

    [SerializeField] TextMeshProUGUI suggestWord;
    [SerializeField] GameObject numberFirst;
    [SerializeField] GameObject numberLast;
    [SerializeField] Sprite[] numberList;

    // Start is called before the first frame update
    void Start()
    {
        gameOver.SetActive(false);
        confirm.SetActive(false);
        numberFirst.SetActive(false);
        numberLast.SetActive(false);
    }

    public void SetSlider(float value)
    {
        slider.GetComponent<SliderController>().SetSlider(value);
    }

    public void UpdateSlider(float value)
    {
        slider.GetComponent<SliderController>().UpdateSlider(value);
    }

    public void GameOver()
    {
        gameOver.SetActive(true);
    }

    public void Confirm(bool isShow)
    {
        Time.timeScale = (isShow) ? 0 : 1;
        confirm.SetActive(isShow);
    }

    public void ShowNumberFirst(int value, bool isShow)
    {
        numberFirst.SetActive(isShow);
        numberFirst.GetComponent<Image>().sprite = numberList[value];
    }

    public void ShowNumberLast(int value, bool isShow)
    {
        numberLast.SetActive(isShow);
        numberLast.GetComponent<Image>().sprite = numberList[value];
    }

    public void BackToMenu()
    {
        GetComponent<SceneController>().BackToMenu();
    }

    public void Restart()
    {
        GetComponent<SceneController>().Restart();
    }

    public void Quit()
    {
        GetComponent<SceneController>().Quit();
    }

    public void UpdateScore(int score)
    {
        this.score.text = score.ToString();
    }

    public void UpdateHighScore(int score)
    {
        this.highscore.text = score.ToString();
    }

    public void UpdateWord(string value)
    {
        suggestWord.text = value;
    }
}
