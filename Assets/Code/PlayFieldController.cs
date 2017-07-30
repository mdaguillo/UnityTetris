using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayFieldController : MonoBehaviour {

	private GameObject[][] _playField;

	void Start () {
		// Initialize the playfield and all the tetris units
		_playField = new GameObject[16][]
			{
				new GameObject[10] { GameObject.Find("Row1/Col1"), GameObject.Find("Row1/Col2"), GameObject.Find("Row1/Col3"), GameObject.Find("Row1/Col4"), GameObject.Find("Row1/Col5"), GameObject.Find("Row1/Col6"), GameObject.Find("Row1/Col7"), GameObject.Find("Row1/Col8"), GameObject.Find("Row1/Col9"), GameObject.Find("Row1/Col10")  },
				new GameObject[10] { GameObject.Find("Row2/Col1"), GameObject.Find("Row2/Col2"), GameObject.Find("Row2/Col3"), GameObject.Find("Row2/Col4"), GameObject.Find("Row2/Col5"), GameObject.Find("Row2/Col6"), GameObject.Find("Row2/Col7"), GameObject.Find("Row2/Col8"), GameObject.Find("Row2/Col9"), GameObject.Find("Row2/Col10")  },
				new GameObject[10] { GameObject.Find("Row3/Col1"), GameObject.Find("Row3/Col2"), GameObject.Find("Row3/Col3"), GameObject.Find("Row3/Col4"), GameObject.Find("Row3/Col5"), GameObject.Find("Row3/Col6"), GameObject.Find("Row3/Col7"), GameObject.Find("Row3/Col8"), GameObject.Find("Row3/Col9"), GameObject.Find("Row3/Col10")  },
				new GameObject[10] { GameObject.Find("Row4/Col1"), GameObject.Find("Row4/Col2"), GameObject.Find("Row4/Col3"), GameObject.Find("Row4/Col4"), GameObject.Find("Row4/Col5"), GameObject.Find("Row4/Col6"), GameObject.Find("Row4/Col7"), GameObject.Find("Row4/Col8"), GameObject.Find("Row4/Col9"), GameObject.Find("Row4/Col10")  },
				new GameObject[10] { GameObject.Find("Row5/Col1"), GameObject.Find("Row5/Col2"), GameObject.Find("Row5/Col3"), GameObject.Find("Row5/Col4"), GameObject.Find("Row5/Col5"), GameObject.Find("Row5/Col6"), GameObject.Find("Row5/Col7"), GameObject.Find("Row5/Col8"), GameObject.Find("Row5/Col9"), GameObject.Find("Row5/Col10")  },
				new GameObject[10] { GameObject.Find("Row6/Col1"), GameObject.Find("Row6/Col2"), GameObject.Find("Row6/Col3"), GameObject.Find("Row6/Col4"), GameObject.Find("Row6/Col5"), GameObject.Find("Row6/Col6"), GameObject.Find("Row6/Col7"), GameObject.Find("Row6/Col8"), GameObject.Find("Row6/Col9"), GameObject.Find("Row6/Col10")  },
				new GameObject[10] { GameObject.Find("Row7/Col1"), GameObject.Find("Row7/Col2"), GameObject.Find("Row7/Col3"), GameObject.Find("Row7/Col4"), GameObject.Find("Row7/Col5"), GameObject.Find("Row7/Col6"), GameObject.Find("Row7/Col7"), GameObject.Find("Row7/Col8"), GameObject.Find("Row7/Col9"), GameObject.Find("Row7/Col10")  },
				new GameObject[10] { GameObject.Find("Row8/Col1"), GameObject.Find("Row8/Col2"), GameObject.Find("Row8/Col3"), GameObject.Find("Row8/Col4"), GameObject.Find("Row8/Col5"), GameObject.Find("Row8/Col6"), GameObject.Find("Row8/Col7"), GameObject.Find("Row8/Col8"), GameObject.Find("Row8/Col9"), GameObject.Find("Row8/Col10")  },
				new GameObject[10] { GameObject.Find("Row9/Col1"), GameObject.Find("Row9/Col2"), GameObject.Find("Row9/Col3"), GameObject.Find("Row9/Col4"), GameObject.Find("Row9/Col5"), GameObject.Find("Row9/Col6"), GameObject.Find("Row9/Col7"), GameObject.Find("Row9/Col8"), GameObject.Find("Row9/Col9"), GameObject.Find("Row9/Col10")  },
				new GameObject[10] { GameObject.Find("Row10/Col1"), GameObject.Find("Row10/Col2"), GameObject.Find("Row10/Col3"), GameObject.Find("Row10/Col4"), GameObject.Find("Row10/Col5"), GameObject.Find("Row10/Col6"), GameObject.Find("Row10/Col7"), GameObject.Find("Row10/Col8"), GameObject.Find("Row10/Col9"), GameObject.Find("Row10/Col10")  },
				new GameObject[10] { GameObject.Find("Row11/Col1"), GameObject.Find("Row11/Col2"), GameObject.Find("Row11/Col3"), GameObject.Find("Row11/Col4"), GameObject.Find("Row11/Col5"), GameObject.Find("Row11/Col6"), GameObject.Find("Row11/Col7"), GameObject.Find("Row11/Col8"), GameObject.Find("Row11/Col9"), GameObject.Find("Row11/Col10")  },
				new GameObject[10] { GameObject.Find("Row12/Col1"), GameObject.Find("Row12/Col2"), GameObject.Find("Row12/Col3"), GameObject.Find("Row12/Col4"), GameObject.Find("Row12/Col5"), GameObject.Find("Row12/Col6"), GameObject.Find("Row12/Col7"), GameObject.Find("Row12/Col8"), GameObject.Find("Row12/Col9"), GameObject.Find("Row12/Col10")  },
				new GameObject[10] { GameObject.Find("Row13/Col1"), GameObject.Find("Row13/Col2"), GameObject.Find("Row13/Col3"), GameObject.Find("Row13/Col4"), GameObject.Find("Row13/Col5"), GameObject.Find("Row13/Col6"), GameObject.Find("Row13/Col7"), GameObject.Find("Row13/Col8"), GameObject.Find("Row13/Col9"), GameObject.Find("Row13/Col10")  },
				new GameObject[10] { GameObject.Find("Row14/Col1"), GameObject.Find("Row14/Col2"), GameObject.Find("Row14/Col3"), GameObject.Find("Row14/Col4"), GameObject.Find("Row14/Col5"), GameObject.Find("Row14/Col6"), GameObject.Find("Row14/Col7"), GameObject.Find("Row14/Col8"), GameObject.Find("Row14/Col9"), GameObject.Find("Row14/Col10")  },
				new GameObject[10] { GameObject.Find("Row15/Col1"), GameObject.Find("Row15/Col2"), GameObject.Find("Row15/Col3"), GameObject.Find("Row15/Col4"), GameObject.Find("Row15/Col5"), GameObject.Find("Row15/Col6"), GameObject.Find("Row15/Col7"), GameObject.Find("Row15/Col8"), GameObject.Find("Row15/Col9"), GameObject.Find("Row15/Col10")  },
				new GameObject[10] { GameObject.Find("Row16/Col1"), GameObject.Find("Row16/Col2"), GameObject.Find("Row16/Col3"), GameObject.Find("Row16/Col4"), GameObject.Find("Row16/Col5"), GameObject.Find("Row16/Col6"), GameObject.Find("Row16/Col7"), GameObject.Find("Row16/Col8"), GameObject.Find("Row16/Col9"), GameObject.Find("Row16/Col10")  }
			};
	}
	
	// Update is called once per frame
	void Update () {
		// Check for player input
		if (Input.GetKeyDown("up"))
		{
			// Set the new sprite
			SpriteRenderer renderer = _playField[0][0].GetComponent<SpriteRenderer>();
			Sprite[] newSprite = Resources.LoadAll<Sprite>("sprites/tetris_unit_spritesheet");
			renderer.sprite = newSprite[4];
		}
	}
}
