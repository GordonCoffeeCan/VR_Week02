using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponBehavior : MonoBehaviour {
    public float rotationSpeed = 1;

    private Transform _weaponPivot;
    private Transform _trans;
    private Transform _mainCamera;

    private void Awake() {
        _trans = this.transform;
        _mainCamera = Camera.main.transform;
        _weaponPivot = _trans.FindChild("WeaponPivot");
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void FixedUpdate() {
        Quaternion _pivotTargetRotation = Quaternion.Euler(_mainCamera.eulerAngles.x, _mainCamera.eulerAngles.y, 0);
        _weaponPivot.rotation = Quaternion.Slerp(_weaponPivot.rotation, _pivotTargetRotation, rotationSpeed * Time.deltaTime);
    }
}
