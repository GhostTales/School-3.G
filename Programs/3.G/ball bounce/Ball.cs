using System.Data;
using System.Numerics;
using Godot;
using System;

public partial class Ball : RigidBody2D
{
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
		GD.Print($"X : {String.Format("{0:0.00}", GlobalPosition.X)} | Y : {String.Format("{0:0.00}", GlobalPosition.Y)}");
	}

	public override void _IntegrateForces(PhysicsDirectBodyState2D state)
	{
		if (GlobalPosition.X > 1152 - 200 || GlobalPosition.X < 0 + 200) { }
		if (GlobalPosition.Y > 648 - 200 || GlobalPosition.Y < 0 + 200) { }

		base._IntegrateForces(state);
	}
}
