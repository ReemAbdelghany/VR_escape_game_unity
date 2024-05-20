using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TorchVerifySocket : MonoBehaviour
{
    [HideInInspector] public TorchSocket RightSocket;
    [HideInInspector] public TorchSocket LeftSocket;

    public GameObject SECONDBIGDISAPEARDOOR;
    public GameObject THIRDBIGDISAPEARDOOR;
    public GameObject flam;

    private void Start()
    {
        RightSocket = GameObject.Find("RightSocketChild").GetComponent<TorchSocket>();
        LeftSocket = GameObject.Find("leftSocketChild").GetComponent<TorchSocket>();
    }

    void Update()
    {
        if (RightSocket.isPlaced && LeftSocket.isPlaced)
        {
            Debug.Log("PLEASE FOR THE LOVE OF GOD WORK2");
            SECONDBIGDISAPEARDOOR.SetActive(false);
            THIRDBIGDISAPEARDOOR.SetActive(false);
            flam.SetActive(true);
        }
    }
}
