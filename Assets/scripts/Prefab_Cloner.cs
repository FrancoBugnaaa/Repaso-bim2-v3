using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Prefab_Cloner : MonoBehaviour
{
    public GameObject Prefab;
    public Text inputCLoneAmount;
    public Text displayClonesLeft;
    public InputField Ifield;
    int counter;

    // Start is called before the first frame update
    void Start()
    {
        counter = 0;
        displayClonesLeft.text = "?";
    }

    public void Clone_Prefab()
    {

        if(inputCLoneAmount.text!= "")
        {
            //esto es para que si esta vacio no se active ni siquiera.
            Ifield.readOnly = true;

            int cloneAmount = int.Parse(inputCLoneAmount.text);

            if (counter < cloneAmount)
            {
                Instantiate(Prefab);
                counter++;
                displayClonesLeft.text = (cloneAmount - counter).ToString();
            }
            else
            {
                displayClonesLeft.text = "Te pasaste";
            }
        }
        else
        {
            displayClonesLeft.text = "ERROR";
        }
  
    }
}
