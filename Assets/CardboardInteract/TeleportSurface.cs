using UnityEngine;

public class TeleportSurface : Interactive
{
    public new void Interact()
    {
        RaycastHit hit = CameraInteract.GetLatestHit();
        CameraInteract.GetPlayerTransform().position = 
            hit.point + hit.normal * CameraInteract.GetPlayerHeight();
    }
}
