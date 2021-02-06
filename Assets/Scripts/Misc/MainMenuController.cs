using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour
{
    [SerializeField]
    private Text m_HighScore;
    
    private string m_DefaultHighScoreText;

    private void Awake() {
        Cursor.lockState = CursorLockMode.None;
        m_DefaultHighScoreText = m_HighScore.text;
    }
    
    public void PlayArena() {
        SceneManager.LoadScene("Arena");
    }
    
    public void Quit() {
        Application.Quit();
    }
    
    private void Start() {
        UpdateHighScore();
    }
    
    private void UpdateHighScore() {
        if (PlayerPrefs.HasKey("HS")) {
            m_HighScore.text = m_DefaultHighScoreText.Replace("&S", PlayerPrefs.GetInt("HS").ToString());
        } else {
            PlayerPrefs.SetInt("HS", 0);
            m_HighScore.text = m_DefaultHighScoreText.Replace("&S", "0");
        }
    }
    
    public void ResetHighScore() {
        PlayerPrefs.SetInt("HS", 0);
        UpdateHighScore();
    }
}
