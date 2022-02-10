using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Lore : MonoBehaviour
{
    public Text text;

    public string[] lore;

    private int index = 0;


    void Start()
    {
        text.text = lore[0];
    }

    void TextReplace()
    {
        index++;

        if (index >= lore.Length)
        {
            SceneManager.LoadScene(1);
        }

        else
        {
            text.text = lore[index];
        }
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            TextReplace();
        }
    }
}
