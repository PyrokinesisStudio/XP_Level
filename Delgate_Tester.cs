using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delgate_Tester : MonoBehaviour
{
    private void Start()
    {
        XP_Lvl_Delegates.XpChangeDelegate += MyDelegate;//----subscribe to the delegate
        XP_Lvl_Delegates.XpChangeEvent += MyEvent;//----subscribe to the event
    }

    public void MyDelegate()//---method for the delegate
    {
        Debug.Log("Delegate");
    }

    public void MyEvent()//---method for the event
    {
        Debug.Log("Event");
    }

    public void UnityEvent()//---method for the Unity Event. Notice we never subscribe to it. We set/subscribe to it via the inspector
    {
        Debug.Log("Unity Event");
    }

    private void OnDisable()//-----unsubscribe from the delegates/events to prevent memory leaks
    {
        XP_Lvl_Delegates.XpChangeDelegate -= MyDelegate;
        XP_Lvl_Delegates.XpChangeEvent -= MyEvent;
    }
}
