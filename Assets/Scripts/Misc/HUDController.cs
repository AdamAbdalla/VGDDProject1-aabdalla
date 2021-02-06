using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HUDController : MonoBehaviour
{
    [SerializeField]
    private RectTransform m_HealthBar;
    
    private float p_HealthBarOrigWidth;
    
    private void Awake() {
        p_HealthBarOrigWidth = m_HealthBar.sizeDelta.x;
    }
    
    public void UpdateHealth(float percent) {
        m_HealthBar.sizeDelta = new Vector2(p_HealthBarOrigWidth * percent, m_HealthBar.sizeDelta.y);
    }
}
