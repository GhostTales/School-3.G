using Godot;
using System;
using System.Collections.Generic;

public partial class item_spin : Node2D
{
	// Called when the node enters the scene tree for the first time.
	private AnimatedSprite2D anim;
	private AudioStreamPlayer2D pick_up;
	public int item_spin_animation = 2;
	private List<string> animations = new List<string>() { "gem_spin", "silver_coin_spin", "gold_coin_spin" };
	public override void _Ready()
	{
		anim = GetNode<AnimatedSprite2D>("AnimatedSprite2D");
		pick_up = GetNode<AudioStreamPlayer2D>("pick_up");
		pick_up.Play();
	}

	public void Set_Spin_Anim(int n) { item_spin_animation = n; }

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{

		if (item_spin_animation < animations.Count)
		{
			anim.Play(animations[item_spin_animation]);
		}
		else
			GD.Print($"error item_spin_animation ({item_spin_animation}) out of index ({animations.Count - 1})");
	}
}
