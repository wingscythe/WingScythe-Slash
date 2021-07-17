using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharacterSelection : MonoBehaviour
{
    private int currentCharacter;

    void Awake()
    {
        SelectCharacter(0);
    }
    private void SelectCharacter(int index)
    {
        for (int i = 0; i < transform.childCount; i++)
        {
            transform.GetChild(i).gameObject.SetActive(i == index);
        }
    }

    public void ChangeCharacter(int value)
    {
        currentCharacter += value;
        if (currentCharacter >= transform.childCount)
        {
            currentCharacter = 0;
        }
        else if (currentCharacter < 0)
        {
            currentCharacter = transform.childCount - 1;
        }
        SelectCharacter(currentCharacter);
    }
}
