using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class PlusScoreScript : MonoBehaviour
{
    public Score scr;

    public void OnTriggerEnter2D(Collider2D collision)
    {
        scr.PlusScoreScript();
    }
}
