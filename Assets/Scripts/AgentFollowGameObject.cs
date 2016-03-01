using UnityEngine;
using System.Collections;

//Needs 2 references and a line of code in the Update method
//Nav Mesh agent + game object it's following (the player)

public class AgentFollowGameObject : MonoBehaviour {

	public GameObject playerDude;
	public NavMeshAgent badGuy;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		badGuy.SetDestination (this.playerDude.transform.position);
		//make badGuy follow playerDude with this script...
	
	}
}
