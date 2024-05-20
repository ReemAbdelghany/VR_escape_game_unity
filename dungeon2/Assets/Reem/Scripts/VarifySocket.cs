using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VarifySocket : MonoBehaviour
{
    [HideInInspector] public CheckSockets checkSocketBIG;
    [HideInInspector] public CheckSockets checkSocketMID;
    [HideInInspector] public CheckSockets checkSocketTINY;

    public GameObject FIRSTBIGDISAPEARDOOR;

    private void Start()
    {
        checkSocketBIG = GameObject.Find("bigSocketChild").GetComponent<CheckSockets>();
        checkSocketMID = GameObject.Find("MiddleSocketChild").GetComponent<CheckSockets>(); 
        checkSocketTINY = GameObject.Find("VTinySocketChild").GetComponent<CheckSockets>();

    }

    void Update()
    {
        if (checkSocketTINY.isPlaced && checkSocketMID.isPlaced && checkSocketBIG.isPlaced)
        {
            Debug.Log("PLEASE FOR THE LOVE OF GOD WORK");
            FIRSTBIGDISAPEARDOOR.SetActive(false);
        }
        //Debug.Log(ISBIGplaced);
    }
}
