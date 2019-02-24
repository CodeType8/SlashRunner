using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : Singleton<UIManager>
{
    [SerializeField]
    private GameObject _title = null;
    [SerializeField]
    private Button _startButton = null;
    [SerializeField]
    private Button _tipButton = null;

    public void StartButton ()
    {
        ShowTip();
        _title.SetActive(false);
        _startButton.gameObject.SetActive(false);
    }

    public void TipButton()
    {
        Showscore();
        Manager.Instance.isplay = true;
        _startButton.gameObject.SetActive(false);
    }

    private void ShowTip()
    {
        _startButton.gameObject.SetActive (true);
    }

    private void Showscore()
    {

    }
}
