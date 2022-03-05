using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomBehaviourTest : MonoBehaviour
{
    public List<CustomPureClass> pureClasses = new List<CustomPureClass>();

    private void Start() {
        for (int i = 0; i < 200; i++) {
            var p = new CustomPureClass();
            p.id = i;

            pureClasses.Add(p);
            UpdateManager.RegisterUpdateable(UpdateGroupName.Time2, p);
        }        
    }
}

public class CustomPureClass : IUpdatable
{
    public int id;

    public void OnUpdate() {
        Debug.Log("Pure C# Class Call id: " + id);
    }
}
