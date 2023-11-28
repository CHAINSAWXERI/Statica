using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class FormulaToTextH : MonoBehaviour
{
    [SerializeField] TMP_Text _formula;
    [SerializeField] private TextFormulas _txtFormulas;

    void Start()
    {
        _formula.text = _txtFormulas.H;
    }
}
