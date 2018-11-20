using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shop : MonoBehaviour {

	public TurretBlueprint standardTurret;
	public TurretBlueprint missileLuncher;
	public TurretBlueprint laserBeamer;

	BuildManager buildManager;

	void Start()
	{
		buildManager = BuildManager.instance;
	}

	public void SelectStandardTurret()
	{
		buildManager.SelectTurretToBuild (standardTurret);
	}

	public void SelectMissileLauncher()
	{
		buildManager.SelectTurretToBuild (missileLuncher);
	}

	public void SelectLaserBeamer()
	{
		buildManager.SelectTurretToBuild (laserBeamer);
	}

}
