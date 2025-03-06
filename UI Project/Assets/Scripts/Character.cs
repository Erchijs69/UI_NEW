using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    public int health;
    public void Shout()
    {
        Debug.Log("I 'we played these games before... oh, yeah, and I am " + name.ToUpper());
    }
}
