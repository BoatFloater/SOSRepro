
using MMMaellon;
using UdonSharp;
using UnityEngine;
using VRC.SDKBase;
using VRC.Udon;

public class Teleporter : UdonSharpBehaviour
{
    [SerializeField] private SmartObjectSync[] smartSync;
    [SerializeField] private Transform[] target;
    
    void Start()
    {
    }

    public void Teleport1()
    {
        this.internalTeleport(0);
    }

    public void Teleport2()
    {
        this.internalTeleport(1);
    }

    public void Teleport3()
    {
        this.internalTeleport(2);
    }

    private void internalTeleport(int id)
    {
        Debug.Log("internal teleport");
        Networking.SetOwner(Networking.LocalPlayer, this.smartSync[id].gameObject);
        this.smartSync[id].TeleportTo(this.target[id].position, this.target[id].rotation, Vector3.zero, Vector3.zero);
    }
}
