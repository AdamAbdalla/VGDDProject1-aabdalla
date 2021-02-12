using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircleAttackScript : Ability
{
    public override void Use(Vector3 spawnPos) {
        RaycastHit[] hits = Physics.SphereCastAll(spawnPos, m_Info.Range, transform.forward, 0);
        foreach (RaycastHit hit in hits) {
            if (hit.collider.CompareTag("Enemy")) {
            hit.collider.GetComponent<EnemyController>().DecreaseHealth(m_Info.Power);
            }
        }
        var emitterShape = cc_PS.shape;
        emitterShape.length = m_Info.Range;
        cc_PS.Play();
    }
}
