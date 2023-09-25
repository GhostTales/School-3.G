using Godot;



public partial class player : CharacterBody2D
{
	private AnimatedSprite2D anim;
	private AudioStreamPlayer2D walking;
	public Vector2 current_dir = new Vector2(0, 0); // Vi gemmer retning her

	public override void _Ready()
	{
		anim = GetNode<AnimatedSprite2D>("AnimatedSprite2D");
		walking = GetNode<AudioStreamPlayer2D>("walking");
		anim.Play("idle");
	}

	[Export]
	public int Speed { get; set; } = 100;    // Hastighed, redigerbar fra Inspector (ved Export)

	public void GetInput()
	{
		Vector2 inputDirection = Input.GetVector("left", "right", "up", "down");
		Velocity = inputDirection * Speed;

		if (inputDirection != new Vector2(0, 0))
		{
			PlayAnimation(1);
			walking.Play();
			current_dir = inputDirection;
		}
		else
			PlayAnimation(0);


	}

	public override void _PhysicsProcess(double delta)
	{
		GetInput();     // Henter Player keyboard input
		MoveAndSlide(); // Flytter sig i henhold fysikkens kræfter og glider af kolliderende Objekter
	}

	void PlayAnimation(int movement)
	{

		Vector2 dir = current_dir;

		if (dir == new Vector2(1, 0))
		{
			anim.FlipH = false;
			if (movement == 1)
			{
				anim.Play("side_walk");
			}
			else if (movement == 0)
			{
				anim.Play("side_idle");
			}
		}
		else if (dir == new Vector2(-1, 0))
		{
			anim.FlipH = true;
			if (movement == 1)
				anim.Play("side_walk");
			else if (movement == 0)
				anim.Play("side_idle");
		}
		else if (dir == new Vector2(0, -1))
		{
			if (movement == 1)
				anim.Play("back_walk");
			else if (movement == 0)
				anim.Play("back_idle");
		}
		else if (dir == new Vector2(0, 1))
		{
			if (movement == 1)
				anim.Play("front_walk");
			else if (movement == 0)
				anim.Play("front_idle");
		}
	}
}

