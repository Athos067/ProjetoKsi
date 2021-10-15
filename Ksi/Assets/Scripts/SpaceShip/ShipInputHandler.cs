using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipInputHandler : MonoBehaviour
{
    //Components
    ShipController shipController;

    private void Awake()
    {
        shipController = GetComponent<ShipController>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 inputVector = Vector2.zero;

        inputVector.x = Input.GetAxis("Horizontal"); //input de rota��o da nave
        inputVector.y = Input.GetAxis("Vertical"); // input de acelera��o da nave

        if (inputVector.y <= 0)
        {
            inputVector.y = 0; //n�o deixa dar r�
        }

        shipController.SetInputVector(inputVector);
    }
}
