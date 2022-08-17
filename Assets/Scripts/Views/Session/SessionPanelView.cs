using System.Collections;
using System.Collections.Generic;
using Controlers;
using ControlersData;
using UnityEngine;
using UnityEngine.UI;
using Views.Result.DailyPanelView;
using Views.ResultMenuPanelView.ProgressPanelView;

public class SessionPanelView : MonoBehaviour
{
    public Text currentLevelText;
    public MainMenuPanelVIew mainMenuPanel;
    public ResultMenuPanelView resultMenuPanel;
    public DailyInfoView DailyInfoView;
    public ProgressInfoView ProgressInfoView;
    
    [SerializeField] private Image backGround;
    
    public void InitView()
    {
        currentLevelText.text = LevelsCnt.GetCurrentLevelID() + 1 +"";
        UpdateBackGround();
        DailyInfoView.InitView();
        ProgressInfoView.InitView();
    }

    public void OpenMainMenu()
    {
        AudioCnt audioCnt = FindObjectOfType<AudioCnt>();
        audioCnt.CreateNewAudioElement(8);
        mainMenuPanel.gameObject.SetActive(true);
        mainMenuPanel.InitView();
    }

    public void OpenResultMenu()
    {
        AudioCnt audioCnt = FindObjectOfType<AudioCnt>();
        audioCnt.CreateNewAudioElement(8);
        resultMenuPanel.gameObject.SetActive(true);
        resultMenuPanel.InitView();
    }
    
    public void Start()
    {
        BackGroundCnt.SetCurrentBackGroundEvent += UpdateBackGround;
    }

    public void OnDestroy()
    {
        BackGroundCnt.SetCurrentBackGroundEvent -= UpdateBackGround;
    }

    public void UpdateBackGround()
    {
        backGround.sprite = BackGroundCnt.GetCurrentBackGround().backGroundSession;
    }
}
