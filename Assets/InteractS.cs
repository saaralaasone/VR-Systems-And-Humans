using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractS : Interactive
{
    public new void Interact()
    {
        //Interaction here
        transform.Rotate(0f, 45f, 0f);
    }
}
