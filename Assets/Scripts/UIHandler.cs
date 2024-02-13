using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIHandler : MonoBehaviour
{
    [SerializeField] TMP_InputField makeInputField, modelInputField, yearInputField;
    [SerializeField] TMP_Text makeText, modelText, yearText, speedText;
    string makeTextDefaultString, modelTextDefaultString, yearTextDefaultString, speedTextDefaultString;
    Car _createdCar;

    public void Start()
    {
        makeTextDefaultString = makeText.text;
        modelTextDefaultString = modelText.text;
        yearTextDefaultString = yearText.text;
        speedTextDefaultString = speedText.text;
    }
    public void OnEnterButtonPressed()
    {
        if (makeInputField.text != null && modelInputField.text != null && yearInputField.text != null) 
        {
            _createdCar = new Car(uint.Parse(yearInputField.text), makeInputField.text, modelInputField.text);
            Debug.Log(_createdCar.Make);
            Debug.Log(_createdCar.Model);
            Debug.Log(_createdCar.Year);
            Debug.Log(_createdCar.Speed);
        }
        makeText.text = makeTextDefaultString + _createdCar.Make;
        modelText.text = modelTextDefaultString + _createdCar.Model;
        yearText.text = yearTextDefaultString + _createdCar.Year;
        speedText.text = speedTextDefaultString + _createdCar.Speed;
    }
    public void Update()
    {
        if (_createdCar != null)
        {
            if (Input.GetKeyDown(KeyCode.UpArrow))
            {
                _createdCar.Accelerate(1);
                speedText.text = speedTextDefaultString + _createdCar.Speed;
            }
            if (Input.GetKeyDown(KeyCode.DownArrow))
            {
                _createdCar.Decelerate(1);
                speedText.text = speedTextDefaultString + _createdCar.Speed;
            }
        }
    }
}
