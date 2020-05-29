using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class Pause : MonoBehaviour
{
    // Start is called before the first frame update
    public void PauseToogle()
    {
        if (Time.timeScale == 1f)
        {
            Time.timeScale = 0f;
        }
        else
        {
            Time.timeScale = 1f;
        }
    }
}
