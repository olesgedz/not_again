﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor (typeof(Inventory))] 
public class InventoryEditor : MonoBehaviour
{
    private SerializedProperty itemImagesProperty;
    private SerializedProperty itemProperty;
}