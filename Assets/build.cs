using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class build : MonoBehaviour {

	public float speed = 5f;

	/// <summary>
	/// Reset is called when the user hits the Reset button in the Inspector's
	/// context menu or when adding the component the first time.
	/// </summary>
	void Reset()
	{
		speed = 25f;
	}

	/// <summary>
	/// Awake is called when the script instance is being loaded.
	/// </summary>
	void Awake()
	{
		Debug.Log('awake')
	}

	/// <summary>
	/// This function is called when the object becomes enabled and active.
	/// </summary>
	void OnEnable()
	{
		Debug.Log('onEnable');
	}

	/// <summary>
	/// Start is called on the frame when a script is enabled just before
	/// any of the Update methods is called the first time.
	/// </summary>
	void Start()
	{
		Debug.Log('start');

		Vector3 myPos = new Vector3(2f,2f,2f);

		transform.position = myPos;

	}

	/// <summary>
	/// Update is called every frame, if the MonoBehaviour is enabled.
	/// </summary>
	void Update()
	{
		Debug.Log('update');
	}

	/// <summary>
	/// This function is called every fixed framerate frame, if the MonoBehaviour is enabled.
	/// </summary>
	void FixedUpdate()
	{
		Debug.Log('fixedupdate');
		Debug.Log();
	}

}
