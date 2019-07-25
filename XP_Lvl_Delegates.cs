using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;//---need this to for Untiy Events
using UnityEngine.UI;//---need this

public class XP_Lvl_Delegates : MonoBehaviour
{
    public float xp { get; private set; }
    public int level { get; private set; }

    private float xpForNextLevel;//how much xp to reach next level
    public float xpLevelAdjust;//how much to increase the xp when the player levels up

    public Text xpText;
    public Text levelText;

    //----------------Delegate----------------
    public delegate void OnXpChange();
    public static OnXpChange XpChangeDelegate;
    //----------------------------------------

    //----------------Event-------------------
    public delegate void OnXpChangeEvent();
    public static event OnXpChangeEvent XpChangeEvent;
    //----------------------------------------

    //----------------Unity Event-------------
    public UnityEvent UnityXpChangeEvent;
    //----------------------------------------



    private void Start()
    {
        xpForNextLevel = level * xpLevelAdjust;
        UpdateUI();
    }

    //----------------------Testing Only-----------------------
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.G))
        {
            float amnt = Random.Range(1f, 40f);
            Debug.Log("Added " + amnt.ToString() + " xp");
            AddXp(amnt);
        }
    }
    //----------------------Testing Only-----------------------

    public void AddXp(float _amnt)
    {
        XpChangeDelegate();//--call the Delegate
        XpChangeEvent();//---call the Event

        if (UnityXpChangeEvent != null)
        {
            UnityXpChangeEvent.Invoke();//---call the Unity Event
        }

        xp += _amnt;

        if (xp >= xpForNextLevel)
        {
            xp = xp - xpForNextLevel;
            level += 1;
            xpForNextLevel += level * xpLevelAdjust;
        }

        UpdateUI();
    }

    private void UpdateUI()
    {
        xpText.text = "XP: " + xp.ToString();
        levelText.text = "Level: " + level.ToString();
    }
}
