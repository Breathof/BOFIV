using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeAnimation : MonoBehaviour {

    public Animation anim;
    public KeyCode attack;

	void Update () {
		if (Input.GetKeyDown(attack)){
            anim.Play("loop");
        }
	}
}
