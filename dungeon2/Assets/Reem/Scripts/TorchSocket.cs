using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class TorchSocket : MonoBehaviour
{
    private XRSocketInteractor socketInteractable;
    public TorchVerifySocket verifySocket;

    public bool isPlaced;

    private void Start()
    {
        socketInteractable = GetComponent<XRSocketInteractor>();
        socketInteractable.selectEntered.AddListener(x => CorrectSlotInput());
        socketInteractable.selectExited.AddListener(x => ShapeSelectExit());

        verifySocket = FindObjectOfType<TorchVerifySocket>();
    }

    private void CorrectSlotInput()
    {
        isPlaced = true;
    }

    private void ShapeSelectExit()
    {
        isPlaced = false;
    }
}
