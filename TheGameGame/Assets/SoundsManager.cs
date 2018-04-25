using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundsManager : MonoBehaviour
{
	[FMODUnity.EventRef] public string[] sounds;

	public void PlaySound(int i)
	{
		FMODUnity.RuntimeManager.PlayOneShot(sounds[i]);
	}
}
