﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIButton : MonoBehaviour
{
    public void Restart()
    {
        GameManager.Instance.Restart();
    }
 
}
