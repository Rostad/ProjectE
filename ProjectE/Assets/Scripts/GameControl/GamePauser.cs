using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public static class GamePauser
{
    public static bool IsPaused { get; private set; } = false;
    

    public static void ShouldPause(bool b)
    {
        IsPaused = b;
    }




}
