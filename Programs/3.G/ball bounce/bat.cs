using Godot;
using System;

public partial class bat : CharacterBody2D
{

	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
		float AMOUNT = 10;
		if (Input.IsKeyPressed(Key.A))
		{
			this.Position += new Vector2(-AMOUNT, 0);
		}
		if (Input.IsKeyPressed(Key.D))
		{
			this.Position += new Vector2(AMOUNT, 0);
		}
	}

}
