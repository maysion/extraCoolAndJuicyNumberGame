using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class NumberWizard : MonoBehaviour {
    
    [SerializeField] public int max;
    [SerializeField] public int min;
    [SerializeField] TextMeshProUGUI guessText;

    public int guess;

    // Use this for initialization
    public void Start () {
        StartGame();
	}

    public void StartGame() {
        NextGuess();
    }

    public void OnPressHigher()
    {
        if (ValueHolder.GuessCounter != 0)
        {
            min = guess + 1;
            ValueHolder.Min = min;
            NextGuess();
        }
    }

    public void OnPressLower()
    {
        if (ValueHolder.GuessCounter != 0)
        {
            max = guess - 1;
            ValueHolder.Max = max;
            NextGuess();
        }
    }

    public void NextGuess()
    {
        if (min < max)
        {
            guess = Random.Range(min, max + 1);
            guessText.text = guess.ToString();
            ValueHolder.ValueOfGuess = guess;
        }
        else if (min + 1 == max)
        {
            guess = Random.Range(min, max + 1);
            guessText.text = guess.ToString();
            ValueHolder.ValueOfGuess = guess;
        }
        else if (min == max)
        {
            guess = min;
            guessText.text = guess.ToString();
            ValueHolder.ValueOfGuess = guess;
        }
    }

    public int GetGuess()
    {
        return guess;
    }
}
