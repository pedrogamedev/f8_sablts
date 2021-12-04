using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum UpdateGroupName
{
    Time2,
    Time5
}

public static class UpdateManager
{
    static Dictionary<UpdateGroupName, UpdateGroup> updateGroups = new Dictionary<UpdateGroupName, UpdateGroup>();
    static Dictionary<UpdateGroupName, bool> updateGroupsActive = new Dictionary<UpdateGroupName, bool>();

    public static void Update() {
        foreach (var group in updateGroups) {
            if (updateGroupsActive[group.Key]) {

            }
        }
    }
}
