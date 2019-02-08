using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class FinalNumber : MonoBehaviour
{
    
    [SerializeField] TextMeshProUGUI finalNumber;
    [SerializeField] TextMeshProUGUI stopGameText;

    

    void Start()
    {

        int myValue = ValueHolder.ValueOfGuess;


        if (myValue == -1)
        {
            stopGameText.text = "Lopetit pelin kesken,\n miksi hylkäsit minut senpai :(";
            finalNumber.text = "";
        }
        else if (myValue == -2)
        {
            finalNumber.text = "Voitit tällä kertaa... mutta onnistutko siinä uudelleen";
        }
        else
        {
            finalNumber.text = "Numerosi oli: " + myValue.ToString();
        }

    }


}
