using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class BaseTetramino
{
	private TetrisUnit[][] _shape;
	public TetrisUnit[][] Shape { get { return _shape; } }
}