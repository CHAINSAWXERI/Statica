using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResultsFormula : MonoBehaviour
{
    private static Constantas _constanta = Resources.Load("Constantas") as Constantas;

    public static float MoveUpFormula(float m, float a)
    {
        float P;
        P = m * (_constanta.g + a);
        return P;
    }

    public static float FallingDownFormula(float m, float a)
    {
        float P;
        P = m * (_constanta.g - a);
        return P;
    }
}
