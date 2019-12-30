extends KinematicBody

var velocity:=Vector3();
var speed := 50;
var direction := Vector3();
var jump := false;
var can_jump:=true;
const JUMP_FORCE:= 30;
const GRAVITY:= 100;
onready var camera = $Spatial/Camera;

func _ready() -> void:
	Input.set_mouse_mode(Input.MOUSE_MODE_CAPTURED);
	pass;

func _input(event: InputEvent) -> void:
	if event is InputEventMouseMotion:
		var e:InputEventMouseMotion = event;
		self.rotate_y(e.relative.x * -0.003);
		camera.rotate_x(e.relative.y * -0.003);

		if camera.rotation_degrees.x > 70:
			camera.rotation_degrees.x = 70;
		if camera.rotation_degrees.x < -70:
			camera.rotation_degrees.x = -70;

		if self.rotation_degrees.y < -180:
			self.rotation_degrees.y = 180;
		if self.rotation_degrees.y > 180:
			self.rotation_degrees.y = -180;

func _physics_process(delta: float) -> void:

	var imove := Vector2();

	direction = Vector3();

	jump = Input.is_action_pressed("jump");

	if Input.is_action_pressed("forward"):
		imove.y += 1;

	if Input.is_action_pressed("back"):
		imove.y -= 1;

	if Input.is_action_pressed("left"):
		imove.x -= 1;

	if Input.is_action_pressed("right"):
		imove.x += 1;

	imove = imove.normalized();

	direction += -self.transform.basis.z * imove.y;
	direction += self.transform.basis.x * imove.x;

	direction.y = 0;
	direction = direction.normalized();

	velocity.y -= delta * GRAVITY;

	var target = direction * speed;

	var hvel:Vector3 = velocity;
	hvel.y = 0;
	hvel = hvel.linear_interpolate(target, 5 * delta);

	if is_on_floor():
		can_jump = true;

	if jump and can_jump:
		can_jump = false;
		velocity.y = JUMP_FORCE;

	velocity.x = hvel.x;
	velocity.z = hvel.z;

	velocity = move_and_slide(velocity, Vector3.UP);
