using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreCount : MonoBehaviour
{

    [SerializeField] private Text _text;

    public static int _count = 0;

    private void Start()
    {
        _text.text = "SCORE    " + _count.ToString();
    }

    private void Update()
    {
        _text.text = "SCORE    " + _count.ToString();
    }
}
