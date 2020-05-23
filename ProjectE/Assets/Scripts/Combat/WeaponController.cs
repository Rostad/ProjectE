using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Controls;

public class WeaponController : MonoBehaviour
{


    public static WeaponController WeaponControllerInstance;

    private List<Weapon> EquippedWeapons;

    // Start is called before the first frame update
    void Awake()
    {
        WeaponControllerInstance = this;
        LoadEquippedWeapons();                          //TODO Make it so the equipped weapons are the same as the ones player used when last playing
    }

    // Update is called once per frame
    void Update()
    {
        var gamepad = Gamepad.current;
        if(gamepad == null)
        {
            return;
        }
        if (gamepad.rightShoulder.wasPressedThisFrame)
        {
            GamePauser.ShouldPause(!GamePauser.IsPaused);
            Debug.Log(gamepad.rightShoulder.GetType());
        }
    }

    public void LoadEquippedWeapons()
    {

    }

    public List<Weapon> GetEquippedWeapons()
    {
        return EquippedWeapons;
    }


    

}
