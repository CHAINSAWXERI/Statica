using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Calculate : MonoBehaviour
{
    [SerializeField] TMP_InputField inputField1;
    [SerializeField] TMP_InputField inputField2;
    [SerializeField] TMP_Text result;

    public void Calc(bool Num)
    {

        if (Num == true)
        {
            float a = float.Parse(inputField1.text);
            float b = float.Parse(inputField1.text);
            result.text = Convert.ToString(ResultsFormula.MoveUpFormula(a, b));
        }
        else
        {
            float a = float.Parse(inputField1.text);
            float b = float.Parse(inputField1.text);
            result.text = Convert.ToString(ResultsFormula.FallingDownFormula(a, b));
        }
    }
}
