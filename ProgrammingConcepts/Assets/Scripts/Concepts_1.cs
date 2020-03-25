using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Concepts_1 : MonoBehaviour
{
    public string str;

    // Start is called before the first frame update
    void Start()
    {
        DynamicMemberLookUp();
    }

    // Update is called once per frame
    void Update()
    {

    }

    #region Dynamic Member Lookup
    int GetLength(dynamic obj)
    {
        return obj.Length;
    }
    void DynamicMemberLookUp()
    {
        Debug.Log("Returns the length of this string: " + GetLength(str));
        Debug.Log("Returns the length of array: " + GetLength(new int[] { 1, 2, 1, 5 }));
        try
        {

            Debug.Log(GetLength(32));//Cannot return the length of an int and will provide an Exception
        }
        catch (Exception e)
        {
            Debug.LogWarning(e);
        }
    }
    #endregion
}
