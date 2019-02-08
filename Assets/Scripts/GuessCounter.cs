using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GuessCounter : MonoBehaviour
{

    [SerializeField] int arvausNumero;
    [SerializeField] TextMeshProUGUI arvausMaaraTeksti;
    [SerializeField] TextMeshProUGUI lopetusTeksti;
    [SerializeField] TextMeshProUGUI finalGuessText;
    public int currentGuess;
    public SceneLoader sceneLoader;
    public int min;
    public int max;

    public void Start()
    {
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        if (currentSceneIndex == 1)
        {
            currentGuess = arvausNumero - 1;
            ValueHolder.GuessCounter = currentGuess;
            arvausMaaraTeksti.text = "Arvauksia jäljellä: " + currentGuess.ToString();
        }
        else
        {
            currentGuess = ValueHolder.GuessCounter;
            finalGuessText.text = "Arvauksia jäljellä: " + currentGuess.ToString();
        }
    }

    public void VahennaArvoa()
    {
        //min = ValueHolder.Min;
        //max = ValueHolder.Max;
        //if (min != max || max != min)
        //{
            if (currentGuess > 1)
            {
                currentGuess--;
                arvausMaaraTeksti.text = "Arvauksia jäljellä: " + currentGuess.ToString();
                ValueHolder.GuessCounter = currentGuess;
            }
            else
            {
                ValueHolder.GuessCounter = 0;
                arvausMaaraTeksti.text = "Arvaukset loppuivat, paina oikein tai väärin";
                lopetusTeksti.text = "Väärin";
            }
        //}
    }
}
