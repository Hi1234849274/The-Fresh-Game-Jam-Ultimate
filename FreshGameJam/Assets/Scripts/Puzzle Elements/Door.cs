using UnityEngine;

[RequireComponent(typeof(Animator))]
[RequireComponent(typeof(Collider2D))]
public class Door : MonoBehaviour {
Animator anim;
new Collider2D collider;

    void Start() {
        anim = GetComponent<Animator>();
        collider = GetComponent<Collider2D>();
    }
    public void Open() {
        AnimatorControllerParameter parameter = anim.GetParameter(0);
        anim.SetBool(parameter.name, true);
        collider.enabled = false;        
    }
    public void Close() {
        AnimatorControllerParameter parameter = anim.GetParameter(0);
        anim.SetBool(parameter.name, false);
        collider.enabled = true;
    }
}