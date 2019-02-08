using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class ValueHolder
{
    private static int valueOfGuess;

    public static int ValueOfGuess
    {
        get {
            return valueOfGuess;
        }
        set
        {
            valueOfGuess = value;
        }
    }

    private static int guessCounter;

    public static int GuessCounter
    {
        get
        {
            return guessCounter;
        }
        set
        {
            guessCounter = value;
        }
    }

    private static int min;

    public static int Min
    {
        get
        {
            return min;
        }
        set
        {
            min = value;
        }
    }

    private static int max;

    public static int Max
    {
        get
        {
            return max;
        }
        set
        {
            max = value;
        }
    }
} 
