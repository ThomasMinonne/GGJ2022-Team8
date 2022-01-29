using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class GameGrid : MonoBehaviour
{
	public int height = 10;
	public int width = 10;
	public float GridSpaceSize = 1f;
	public bool Generate = false;
	private bool bianco = false;
	private bool even = true;

    [SerializeField] private GameObject gridCellBianco;
	[SerializeField] private GameObject gridCellNero;
	
	private GameObject[,] gameGrid;
	
	private void CreateGrid(){
		gameGrid = new GameObject[height, width];
		
		if(gridCellBianco == null || gridCellNero == null){
			Debug.Log("CELLA MANCANTE NELLA GENERAZIONE DELLA GRIGLIA");
			return;
		}
		//< >
		for(int i = 0; i < height; i++){
			if((i % 2) != 0){
				bianco = false;
			}
			else if ((i % 2) == 0){
				bianco = true;
			}
			for(int j = 0; j < width; j++){
				if(bianco == true){
					gameGrid[i, j] = Instantiate(gridCellBianco, new Vector3(i*GridSpaceSize, 0, j*GridSpaceSize), Quaternion.identity);
					bianco = false;
				}
				else if(bianco == false){
					gameGrid[i, j] = Instantiate(gridCellNero, new Vector3(i*GridSpaceSize, 0, j*GridSpaceSize), Quaternion.identity);
					bianco = true;
				}
				gameGrid[i, j].transform.parent =  transform;
				gameGrid[i, j].gameObject.name = "Cell( X: " + i.ToString() + ", Y: " + j.ToString() + ")";
			}
		}
		bianco = true;
	}
    // Update is called once per frame
    void Update()
    {
        if(Generate == true){
			CreateGrid();
			Generate = false;
		}
    }
}
