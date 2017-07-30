using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TetrisUnit : MonoBehaviour {

	private bool _IsOcuppied;
	public bool IsOcuppied
	{
		get { return _IsOcuppied; }
		set { _IsOcuppied = value; }
	}

	private Sprite _currentSprite;
	public Sprite CurrentSprite
	{
		get { return _currentSprite; }
		set { _currentSprite = value; }
	}

	// Use this for initialization
	void Start () {
		IsOcuppied = false;
		CurrentSprite = Resources.Load<Sprite>(TetrisBlockSprites.EmptyBlock);
	}

	public static class TetrisBlockSprites
	{
		public const string EmptyBlock = "EmptyBlock";
		public const string BlueBlock = "BlueBlock";
		public const string OrangeBlock = "OrangeBlock";
		public const string CyanBlock = "CyanBlock";
		public const string RedBlock = "RedBlock";
		public const string YellowBlock = "YellowBlock";
		public const string GreenBlock = "GreenBlock";
		public const string GreyBlock = "GreyBlock";
	}
}
