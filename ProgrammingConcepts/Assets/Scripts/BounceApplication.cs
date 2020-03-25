using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BounceElement : MonoBehaviour
{
    // Gives access to the application and all instances.
    public BounceApplication app { get { return FindObjectOfType<BounceApplication>(); } }
}
public class BounceApplication : MonoBehaviour
{
    // Reference to the root instances of the MVC.
    public BounceModel model { get { return FindObjectOfType<BounceModel>(); } }
    public BounceView view { get { return FindObjectOfType<BounceView>(); } }
    public BounceController controller { get { return FindObjectOfType<BounceController>(); } }

    // Init things here
    void Start() { }
}