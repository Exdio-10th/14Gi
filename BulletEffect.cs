﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletEffect : MonoBehaviour {

    public float delay = 0f;
	// Use this for initialization
	void Start () {
        Destroy(gameObject, this.GetComponent<Animator>().GetCurrentAnimatorStateInfo(0).length + delay);
    }
	
	// Update is called once per frame
	void Update () {
       
    }

    
}
