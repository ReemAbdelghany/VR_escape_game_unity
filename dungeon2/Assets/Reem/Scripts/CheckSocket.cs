using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class CheckSockets : MonoBehaviour
{
    private XRSocketInteractor socketInteractable;
    public VarifySocket varifySocket;

    public bool isPlaced;
    
    private void Start()
    {
        socketInteractable = GetComponent<XRSocketInteractor>();
        socketInteractable.selectEntered.AddListener(x => CorrectSlotInput());
        socketInteractable.selectExited.AddListener(x => ShapeSelectExit());

        varifySocket = FindObjectOfType<VarifySocket>();


    }

    private void CorrectSlotInput()
    {
        isPlaced = true;
        //varifySocket.ISBIGplaced = false;
        //Debug.Log(varifySocket.ISBIGplaced);
    }

    private void ShapeSelectExit()
    {
        isPlaced = false;
    }


    //public XRSocketInteractor MiddleSocket;
    //public XRSocketInteractor BigSocket;
    //public XRSocketInteractor VTinySocket;

    //public GameObject FIRSTBIGDISAPPEARDOOR;

    //private bool isBigObjectPlaced = false;
    //private bool isMidObjectPlaced = false;
    //private bool isTinyObjectPlaced = false;

    //void Start()
    //{
    //    if (MiddleSocket != null)
    //    {
    //        MiddleSocket.selectEntered.AddListener(OnObjectPlaced);
    //        MiddleSocket.selectExited.AddListener(OnObjectRemoved);
    //    }
    //    else
    //    {
    //        Debug.LogError("MiddleSocket is not assigned.");
    //    }

    //    if (BigSocket != null)
    //    {
    //        BigSocket.selectEntered.AddListener(OnObjectPlaced);
    //        BigSocket.selectExited.AddListener(OnObjectRemoved);
    //    }
    //    else
    //    {
    //        Debug.LogError("BigSocket is not assigned.");
    //    }

    //    if (VTinySocket != null)
    //    {
    //        VTinySocket.selectEntered.AddListener(OnObjectPlaced);
    //        VTinySocket.selectExited.AddListener(OnObjectRemoved);
    //    }
    //    else
    //    {
    //        Debug.LogError("VTinySocket is not assigned.");
    //    }

    //    if (FIRSTBIGDISAPPEARDOOR == null)
    //    {
    //        Debug.LogError("FIRSTBIGDISAPPEARDOOR is not assigned.");
    //    }
    //}

    //private void OnObjectPlaced(SelectEnterEventArgs args)
    //{
    //    IXRSelectInteractable interactable = args.interactableObject;

    //    if (args.interactorObject == MiddleSocket)
    //    {
    //        if (interactable.transform.name == "MidObject")
    //        {
    //            isMidObjectPlaced = true;
    //        }
    //    }
    //    else if (args.interactorObject == BigSocket)
    //    {
    //        if (interactable.transform.name == "BigObject")
    //        {
    //            isBigObjectPlaced = true;
    //        }
    //    }
    //    else if (args.interactorObject == VTinySocket)
    //    {
    //        if (interactable.transform.name == "TinyObject")
    //        {
    //            isTinyObjectPlaced = true;
    //        }
    //    }

    //    CheckAllObjectsPlaced();
    //}

    //private void OnObjectRemoved(SelectExitEventArgs args)
    //{
    //    IXRSelectInteractable interactable = args.interactableObject;

    //    if (args.interactorObject == MiddleSocket)
    //    {
    //        if (interactable.transform.name == "MidObject")
    //        {
    //            isMidObjectPlaced = false;
    //        }
    //    }
    //    else if (args.interactorObject == BigSocket)
    //    {
    //        if (interactable.transform.name == "BigObject")
    //        {
    //            isBigObjectPlaced = false;
    //        }
    //    }
    //    else if (args.interactorObject == VTinySocket)
    //    {
    //        if (interactable.transform.name == "TinyObject")
    //        {
    //            isTinyObjectPlaced = false;
    //        }
    //    }

    //    CheckAllObjectsPlaced();
    //}

    //private void CheckAllObjectsPlaced()
    //{
    //    if (isBigObjectPlaced && isMidObjectPlaced && isTinyObjectPlaced)
    //    {
    //        if (FIRSTBIGDISAPPEARDOOR != null)
    //        {
    //            FIRSTBIGDISAPPEARDOOR.SetActive(false);
    //        }
    //    }
    //}
}
