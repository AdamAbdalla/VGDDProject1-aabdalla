using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager singleton;
    private int m_CurScore;
    private void Awake() {
        if (singleton == null) {
            singleton = this;
        } else if (singleton!= this) {
            Destroy(gameObject);
        }
        m_CurScore = 0;
    }
    
    public void IncreaseScore(int amount) {
        m_CurScore += amount;
    }
    
    private void UpdateHighScore() {
        if (!PlayerPrefs.HasKey("HS")) {
            PlayerPrefs.SetInt("HS", m_CurScore);
            return;
        }
        if ( PlayerPrefs.GetInt("HS") < m_CurScore) {
            PlayerPrefs.SetInt("HS", m_CurScore);
        }
    }
    
    private void OnDisable(){
        UpdateHighScore();
    }
}
