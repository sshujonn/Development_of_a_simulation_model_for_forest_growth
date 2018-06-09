using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class inputSceneStatus : MonoBehaviour {

    public Toggle Tree1;
    public Toggle Tree2;
    public Toggle Tree3;

    public InputField NumTree1;
    public InputField NumTree2;
    public InputField NumTree3;

    public Button propTree1;
    public Button propTree2;
    public Button propTree3;

    //static variables to pass
    public static bool tree1interactability;
    public static bool tree1isOn;
    public static bool tree2interactability;
    public static bool tree2isOn;
    public static bool tree3interactability;
    public static bool tree3isOn;

    public static bool tree1InputInteractability;
    public static bool tree2InputInteractability;
    public static bool tree3InputInteractability;

    public static bool prop1Interactability;
    public static bool prop2Interactability;
    public static bool prop3Interactability;

    static int state = 0;

    void Start()
    {
        if (state==1)
        {
            Tree1.interactable = tree1interactability;
            Tree2.interactable = tree2interactability;
            Tree3.interactable = tree3interactability;

            Tree1.isOn = tree1isOn;
            Tree2.isOn = tree2isOn;
            Tree3.isOn = tree3isOn;

            NumTree1.interactable = tree1InputInteractability;
            NumTree2.interactable = tree2InputInteractability;
            NumTree3.interactable = tree3InputInteractability;

            propTree1.interactable = prop1Interactability;
            propTree2.interactable = prop2Interactability;
            propTree3.interactable = prop3Interactability;
        }
    }
    public void OnClick()
    {
       try
        {
            tree1interactability = Tree1.interactable;
            tree2interactability = Tree2.interactable;
            tree3interactability = Tree3.interactable;

            tree1isOn = Tree1.isOn;
            tree2isOn = Tree2.isOn;
            tree3isOn = Tree3.isOn;

            tree1InputInteractability = NumTree1.interactable;
            tree2InputInteractability = NumTree2.interactable;
            tree3InputInteractability = NumTree3.interactable;

            prop1Interactability = propTree1.interactable;
            prop2Interactability = propTree2.interactable;
            prop3Interactability = propTree3.interactable;
            state = 1;

            Debug.Log(tree1isOn + " "+ tree2isOn + " "+ tree3isOn);


        }
        catch(Exception e)
        {

        }
    }


}
