using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Ability : MonoBehaviour
{
    [SerializeField]
    protected AbilityInfo m_Info;
    
    protected ParticleSystem cc_PS;
    
    private void Awake() {
        cc_PS = GetComponent<ParticleSystem>();
    }
    
    public abstract void Use(Vector3 spawnPos);
}
