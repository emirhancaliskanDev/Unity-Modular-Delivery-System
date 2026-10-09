using System;
using UnityEngine;

public class InteractHandler : MonoBehaviour
{
    void Start()
    {
        PlayerInputs.Instance.OnInteractPressed += DoInteract;
    }

    private void DoInteract(object sender, EventArgs e)
    {
        print("Interact");
    }

    void OnDisable()
    {
        PlayerInputs.Instance.OnInteractPressed -= DoInteract;
    }
}
