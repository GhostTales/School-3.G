using Godot;
using System;
using System.Collections.Generic;

public partial class enemy : CharacterBody2D
{
	public const float speed = 90f;
	[Export]
	public Node2D[] Waypoints = new Node2D[3];
	public int CurrentWaypoint = 0;
	public Vector2 Target;

	public override void _PhysicsProcess(double delta)
	{
		Target = Waypoints[CurrentWaypoint].GlobalPosition;
		Velocity = this.GlobalPosition.DirectionTo(Target) * speed;

		if (this.GlobalPosition.DistanceTo(Target) < 2f)
			CurrentWaypoint = (CurrentWaypoint + 1) % Waypoints.Length;

		MoveAndSlide();
	}

}
