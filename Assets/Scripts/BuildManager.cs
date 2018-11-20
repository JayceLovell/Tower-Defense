using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildManager : MonoBehaviour {


	public static BuildManager instance;

	private TurretBlueprint turretToBuild;

	private Node selectedNode;

	public GameObject buildEffect;
	public GameObject sellEffect;

	public NodeUI nodeUI;

	public bool CanBuild {get { return turretToBuild != null; } }
	public bool HasMoney {get { return PlayerStats.Money >= turretToBuild.cost; } }


	void Awake()
	{
		if(instance != null)
		{
			Debug.LogError ("More than one BuildManager in the Scene");
		}
		instance = this;
	}

	public void SelectTurretToBuild(TurretBlueprint turret)
	{
		turretToBuild = turret;
		selectedNode = null;

		DeselectNode ();
	}

	public void SelectNode(Node node)
	{
		if(selectedNode == node)
		{
			DeselectNode ();
			return;
		}

		selectedNode = node;
		turretToBuild = null;

		nodeUI.SetTarget (selectedNode);
	}

	public TurretBlueprint GetTurretToBuild ()
	{
		return turretToBuild;
	}

	public void DeselectNode()
	{
		selectedNode = null;
		nodeUI.Hide ();
	}

}
