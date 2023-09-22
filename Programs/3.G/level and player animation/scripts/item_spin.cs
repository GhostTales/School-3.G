using Godot;
using System;
using System.Collections.Generic;

public partial class item_spin : Node2D
{
	// Called when the node enters the scene tree for the first time.
	AnimatedSprite2D anim;
	public int item_spin_animation = 1;
	private List<string> animations = new List<string>() { "gem_spin", "silver_coin_spin", "silver_coin_spin" };
	public override void _Ready()
	{
		anim = GetNode<AnimatedSprite2D>("AnimatedSprite2D");
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{

		if (item_spin_animation < animations.Count - 1)
			anim.Play(animations[item_spin_animation]);
		else
			GD.Print($"error item_spin_animation ({item_spin_animation}) out of index ({animations.Count - 1})");
	}
}
