using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Test : MonoBehaviour
{
    public Text SimpleText;
    int a = 0;

    public Rigidbody rigidbody;

    private void OnCollisionEnter (Collision collision)
    {
        a++;
        SimpleText.text = "" + a;
    }
}
