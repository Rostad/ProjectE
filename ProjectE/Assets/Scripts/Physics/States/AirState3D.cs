using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public struct AirState3D : ICharacterState3D
{

    private readonly Controller3D controller;

    private readonly Velocity3D velocity;

    public AirState3D(Controller3D controller, Velocity3D velocity)
    {
        if(controller == null)
        {
            throw new ArgumentNullException("Controller");
        }
        if(velocity == null)
        {
            throw new ArgumentNullException("Velocity");
        }

        this.controller = controller;
        this.velocity = velocity;
    }

    public void Enter()
    {
        velocity.SetY(0.0f);
    }

    public void Exit() { }

    public void Update(Vector3 movementInput, float deltaTime)
    {
        UpdateVelocity(movementInput, deltaTime);
    }

    public CharacterStateSwitch3D HandleCollisions(CollisionFlags collisionFlags)
    {
        CharacterStateSwitch3D stateSwitch;
        if((collisionFlags & CollisionFlags.Below) == CollisionFlags.Below)
        {
            stateSwitch = new CharacterStateSwitch3D(new GroundState3D(controller, velocity));
        } else
        {
            stateSwitch = new CharacterStateSwitch3D();
        }

        return stateSwitch;
    }

    private void UpdateVelocity(Vector3 movementInput, float deltaTime)
    {
        var smoothDampDataX = GetSmoothDampData(movementInput.x);
        var smoothDampDataZ = GetSmoothDampData(movementInput.z);

        velocity.AddY(controller.Gravity * deltaTime);
        velocity.SmoothDampUpdate(movementInput, smoothDampDataX, smoothDampDataZ, deltaTime);
    }

    private SmoothDampData GetSmoothDampData(float input)
    {
        var targetVelocity = input * controller.MoveSpeed;
        var smoothTime = controller.AirAccelerationTime;
        if(Mathf.Abs(input) < MathHelper.FloatEpsilon)
        {
            smoothTime *= controller.AirDeaccelerationScale;
        }

        return new SmoothDampData(targetVelocity, smoothTime);
    }

}
