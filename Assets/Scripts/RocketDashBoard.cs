using TMPro;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class RocketDashBoard : MonoBehaviour
{
    [Header("TargetRocket")]
    [SerializeField] private Rocket playerRocket;

    [Header("UI")]
    [SerializeField] private TextMeshProUGUI currentScoreTxt;
    [SerializeField] private TextMeshProUGUI highScoreTxt;

    private void Start()
    {
        Application.targetFrameRate = 60; // 프레임 속도를 60으로 설정

        try
        {
            GameObject curRocket = GameObject.FindGameObjectWithTag("Player");
            playerRocket = curRocket.GetComponent<Rocket>();
        }
        catch
        {
            #if UNITY_EDITOR
                        UnityEditor.EditorApplication.isPlaying = false;
            #else
                        Application.Quit();
            #endif
        }
    }


    private void Update()
    {
        currentScoreTxt.text = $"{playerRocket.score.ToString("F1")} M";
        highScoreTxt.text = $"HIGH : {playerRocket.highScore.ToString("F1")} M";
    }

    public void Restart()
    {
        SceneManager.LoadScene("RocketLauncher");
    }
}
