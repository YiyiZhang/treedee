using UnityEngine;
using System.Collections;
using UnityEngine.UI;

//Casts a ray in the z direction, hit an object, then stop casting when it hits an object
//Need ORIGIN & DIRECTION

public class RaycastStretcher : MonoBehaviour {

	[SerializeField]
	private Text textUpdate = null;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame

	void Update () {
		Ray r = new Ray(this.transform.position, this.transform.forward); //shoot from center of object along the blue z axis
		RaycastHit roger = new RaycastHit();

		bool wasHit = Physics.Raycast(r, out roger); //Raycast function is in the physics class.
			//The 'out' keyword gives the function permission to use roger however it pleases
			//Ray returns a bool - it either hits something or it doesn't
			//Raycast sends out a ray against all colliders in the scene

		Debug.DrawRay (r.origin, r.direction * 200, Color.blue); //have to turn on gizmos in game view to see it in game view


		if (wasHit == true && roger.collider != null) {
			print ("hit " + roger.collider.gameObject.transform.root.name);
			textUpdate.text = "I just hit " + roger.collider.gameObject.transform.root.name;
		} else if (roger.collider == null) {
			print ("");
		}

		//if (roger.collider != null) {
		//	print (roger.collider.name);
		//}

		//set size of the game object to be the distance of the raycast

		//float rogerCastDist = roger.distance; //stretches the object

		//this.transform.localScale = new Vector3 (2f, 2f, rogerCastDist); //stretches the object
			
	
	}


}
