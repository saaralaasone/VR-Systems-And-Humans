using UnityEngine;

using Google.XR.Cardboard;

public class GlobalTriggerHold : MonoBehaviour
{
    public void Execute()
    {
        // You can create your own custom logic here.

        // By default, Recenters the Cardboard view.
        Api.Recenter();
    }
}
