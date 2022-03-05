using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomBehaviour : MonoBehaviour, IUpdatable
{
    public UpdateGroupName UpdateGroup;

    protected virtual void OnEnable()
    {
        Debug.Log($"Registering {this.gameObject.name} on group {UpdateGroup}");
        UpdateManager.RegisterUpdateable(UpdateGroup, this);
    }

    protected virtual void OnDisable() {
        Debug.Log($"Unregistering {this.gameObject.name} on group {UpdateGroup}");
        UpdateManager.UnregisterUpdateable(UpdateGroup, this);
    }

    private void OnDestroy() {
        Debug.Log($"Unregistering {this.gameObject.name} on group {UpdateGroup}");
        UpdateManager.UnregisterUpdateable(UpdateGroup, this);
    }

    public virtual void OnUpdate()
    {
        
    }
}
