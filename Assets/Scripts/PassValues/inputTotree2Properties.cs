using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class inputTotree2Properties : MonoBehaviour {

    public InputField maxHeight;
    public InputField maxDbh;
    public InputField constA;
    public InputField constB;
    public InputField constC;
    public InputField saltEffect;
    public InputField salinity;
    public InputField constSaltEffect;
    public InputField maxAge;
    public InputField shadeToleranceRanking;

    public static float MaxHeight;
    public static float MaxDbh;
    public static float ConstA;
    public static float ConstB;
    public static float ConstC;
    public static float SaltEffect;
    public static float Salinity;
    public static float ConstSaltEffect;
    public static int MaxAge;
    public static int ShadeToleranceRanking;


    void Update()
    {
        if ((maxHeight != null) && (maxDbh != null) && (constA != null) && (constB != null) && (constC != null) && (saltEffect != null) && (salinity != null) && (constSaltEffect != null) && (maxAge != null) && (shadeToleranceRanking != null))
        {
            try
            {
                MaxHeight = float.Parse(maxHeight.text);
                MaxDbh = float.Parse(maxDbh.text);
                ConstA = float.Parse(constA.text);
                ConstB = float.Parse(constB.text);
                ConstC = float.Parse(constC.text);
                SaltEffect = float.Parse(saltEffect.text);
                Salinity = float.Parse(salinity.text);
                ConstSaltEffect = float.Parse(constSaltEffect.text);
                MaxAge = int.Parse(maxAge.text);
                ShadeToleranceRanking = int.Parse(shadeToleranceRanking.text);
            }
            catch (Exception e) { }
        }
        //Debug.Log(MaxHeight);
    }
}
