using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager 
{
    private static UIManager _instance;

    public UIManager instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = new UIManager();
            }
            return _instance;
        }
    }
}
