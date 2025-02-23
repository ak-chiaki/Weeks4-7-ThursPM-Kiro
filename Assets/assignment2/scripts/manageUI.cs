using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public TMP_Dropdown cakeDropdown; // associate the UI
    public CakeSpawner cakeSpawner;   // associate the cake spawner

    void Start()
    {
      cakeDropdown.onValueChanged.AddListener(delegate { OnCakeTypeChanged(); });
    }

    public void OnCakeTypeChanged()
    {
      int selectedCakeIndex = cakeDropdown.value; // get the selected index
      cakeSpawner.SetCakeType(selectedCakeIndex); // give the index to cakespawner
    }
}