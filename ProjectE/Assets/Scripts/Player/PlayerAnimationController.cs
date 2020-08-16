using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimationController : MonoBehaviour
{
    private Animator playerAnimator;
    private Velocity3D velocity; //Controller3D finds PlayerAnimationController in children and shares it
    void Start()
    {
        playerAnimator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        playerAnimator.SetFloat("VelX", velocity.CurrentNormalized.x);
        playerAnimator.SetFloat("VelY", velocity.CurrentNormalized.z);
        
    }

    public void ShareVelocity(Velocity3D velocity)
    {
        this.velocity = velocity;
    }
}
