using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gate : MonoBehaviour
{
    [SerializeField] int value;
    [SerializeField] DeformationType _deformationType;

    [SerializeField] GateAppereance _gateAppereance;

    private void OnValidate()
    {
        _gateAppereance.UbdateVisual(_deformationType, value);
    }
}
