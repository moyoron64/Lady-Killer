using UnityEngine;
using System.Collections;
/// <summary>
/// Dynamic particle.
///
/// The dynamic particle is the backbone of the liquids effect. Its a circle with physics with 3 states, each state change its physic properties and its sprite color ( so the shader can separate wich particle is it to draw)
/// The particles scale down and die, and have a scale  effect towards their velocity.
///
/// Visit: www.codeartist.mx for more stuff. Thanks for checking out this example.
/// Credit: Rodrigo Fernandez Diaz
/// Contact: q_layer@hotmail.com
/// </summary>

public class DynamicParticle : MonoBehaviour {
	public bool isGrounded = false;
	public enum STATES{WATER,GAS,LAVA,NONE}; //The 3 states of the particle
	STATES currentState=STATES.NONE; //Defines the currentstate of the particle, default is water
	public SpriteRenderer particleImage; //The image is for the metaball shader for the effect, it is onle seen by the liquids camera.
	public Color waterColor,gasColor,lavaColor;//The color of the sprite to be separated inside the shader (the shader has the thresholds for red green or blue in the example)
	float GAS_FLOATABILITY=7.0f; //How fast does the gas goes up?
	public float particleLifeTime=20000000.0f,startTime;//How much time before the particle scalesdown and dies

	void Awake(){
		if (currentState == STATES.NONE)
			SetState (STATES.WATER);
	}

	//The definitios to each state
	public void SetState(STATES newState){
		if(newState!=currentState){ //Only change to a different state
			currentState=newState;
			startTime=Time.time;//Reset the life of the particle on a state change
			rigidbody2D.velocity=new Vector2();	// Reset the particle velocity
			switch(newState){
				case STATES.WATER:
						//particleImage.color=new Color(1f, 0.92f, 0.016f, 0.5f);// Set the color for the metaball shader to know how to draw each particle
						particleImage.color=getColorWithScene(Application.loadedLevelName);// Set the color for the metaball shader to know how to draw each particle
					rigidbody2D.gravityScale=5f; // To simulate Water density
					rigidbody2D.mass=0.01f;
				break;
				case STATES.GAS:
					particleImage.color=gasColor;
					particleLifeTime=particleLifeTime/2.0f;	// Gas lives the time the other particles
					rigidbody2D.gravityScale=0.0f;// To simulate Gas density
					gameObject.layer=LayerMask.NameToLayer("Gas");// To have a different collision layer than the other particles (so gas doesnt rises up the lava but still collides with the wolrd)
				break;
				case STATES.LAVA:
					particleImage.color=lavaColor;
					rigidbody2D.gravityScale=0.3f; // To simulate the lava density
				break;
				case STATES.NONE:
					Destroy(gameObject);
				break;
			}

		}
	}
	void Update () {
		if (isGrounded) {
			isGrounded = false;
			particleLifeTime = 10.0f;
		}
		switch(currentState){
			case STATES.WATER: //Water and lava got the same behaviour
				MovementAnimation();
				ScaleDown();
			break;
			case STATES.LAVA:
				MovementAnimation();
				ScaleDown();
			break;
			case STATES.GAS:
				if(rigidbody2D.velocity.y<50){ //Limits the speed in Y to avoid reaching mach 7 in speed
					rigidbody2D.AddForce (new Vector2(0,GAS_FLOATABILITY)); // Gas always goes upwards
				}
				ScaleDown();
			break;

		}
	}
	// This scales the particle image acording to its velocity, so it looks like its deformable... but its not ;)
	void MovementAnimation(){
		Vector3 movementScale=new Vector3(1.0f,1.0f,1.0f);//Tamaño de textura no de metaball
		movementScale.x+=Mathf.Abs(rigidbody2D.velocity.x)/30.0f;
		movementScale.z+=Mathf.Abs(rigidbody2D.velocity.y)/30.0f;
		movementScale.y=1.0f;
		particleImage.gameObject.transform.localScale=movementScale;
	}
	// The effect for the particle to seem to fade away
	void ScaleDown(){
		float scaleValue = 1.0f-((Time.time-startTime)/particleLifeTime);
		Vector2 particleScale=Vector2.one;
		if (scaleValue <= 0) {
						Destroy (gameObject);
		} else{
			particleScale.x=scaleValue;
			particleScale.y=scaleValue;
			transform.localScale=particleScale;
		}
	}

	// To change particles lifetime externally (like the particle generator)
	public void SetLifeTime(float time){
		particleLifeTime=time;
	}
	// Here we handle the collision events with another particles, in this example water+lava= water-> gas
	void OnCollisionEnter2D(Collision2D other){
		if(currentState==STATES.WATER && other.gameObject.tag=="DynamicParticle"){
			if(other.collider.GetComponent<DynamicParticle>().currentState==STATES.LAVA){
				SetState(STATES.GAS);
			}
		}

		if (other.gameObject.tag == "yuka") {
			isGrounded = true;
		}

	}

	Color getColorWithScene(string sceneName) {
		Color _waterColor;


		switch(sceneName) {
			case "Scene1":
			case "Scene2":
				_waterColor = new Color(0.8f, 0.2f, 0.2f, 1.0f);
				break;
			case "Scene3":
			case "Scene4":
				_waterColor = new Color(0.2f, 0.2f, 0.8f, 1.0f);
				break;
			case "Scene5":
			case "Scene6":
				_waterColor = new Color(0.8f, 0.8f, 0.0f, 1.0f);
				break;
			case "Scene7":
			case "Scene8":
				_waterColor = new Color(0.0f, 1.0f, 1.0f, 1.0f);
				break;
			default :
				_waterColor = new Color(1.0f, 0.0f, 1.0f, 1.0f);
				break;
		}
		return _waterColor;
	}

}
