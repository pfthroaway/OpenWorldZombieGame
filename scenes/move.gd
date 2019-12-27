extends KinematicBody

var velocity:=Vector3();
const GRAVITY:= 9.8;
onready var camera = $Spatial/Camera;

func _ready() -> void:
	Input.set_mouse_mode(Input.MOUSE_MODE_CAPTURED);
	pass;

func _input(event: InputEvent) -> void:
	if event is InputEventMouseMotion:
		var e:InputEventMouseMotion = event;
		self.rotate_y(e.relative.x * -0.006);
		camera.rotate_x(e.relative.y * -0.006);

		if camera.rotation_degrees.x > 70:
			camera.rotation_degrees.x = 70;
		if camera.rotation_degrees.x < -70:
			camera.rotation_degrees.x = -70;

		if self.rotation_degrees.y < -180:
			self.rotation_degrees.y = 180;
		if self.rotation_degrees.y > 180:
			self.rotation_degrees.y = -180;

func _process(delta: float) -> void:

	velocity = Vector3.ZERO;

	if is_on_floor():
		pass
	else:
		velocity.y -= GRAVITY;

	if Input.is_action_pressed("forward"):
		velocity += self.transform.basis.z * -10;

	if Input.is_action_pressed("back"):
		velocity += self.transform.basis.z * 10;

	if Input.is_action_pressed("left"):
		velocity += self.transform.basis.x * -10;

	if Input.is_action_pressed("right"):
		velocity += self.transform.basis.x * 10;

func _physics_process(delta: float) -> void:
	move_and_slide(velocity)
