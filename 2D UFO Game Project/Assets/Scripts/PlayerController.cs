using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour {

	public float speed;
	public Text countText;
	public Text winText;

	private Rigidbody2D rb2d;
	private int count;

	void Start()
	{
		rb2d = GetComponent<Rigidbody2D> ();
		count = 0;
		ShowCount ();
		winText.text = "";
	}

	void FixedUpdate()
	{
		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");
		Vector2 movement = new Vector2 (moveHorizontal, moveVertical);
		rb2d.AddForce (movement * speed);
	}

	void OnTriggerEnter2D(Collider2D other) // When a obeject touch another obeject then call this function and make the veriable TRUE 
	{
		if (other.gameObject.CompareTag ("PickUp")) 
		{
			other.gameObject.SetActive (false);
			count++;
			ShowCount ();
		}
	}

	void ShowCount()
	{
		countText.text = "Count: " + count.ToString ();
		if (count > 14)
		{
			winText.text = "Hay Human you are WIN !!!";
		}
	}

	void update()
	{
		
	}
}
