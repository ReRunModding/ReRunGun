using MelonLoader;
using UnityEngine;

namespace ReRunGun
{
    public class Main : MelonMod
    {
		bool gunActive = false;

		public override void OnUpdate()
		{
			if (Input.GetKeyDown(KeyCode.G))
			{
				if (gunActive)
				{
					gunActive = false;
				}
				else
				{
					gunActive = true;
				}
			}

			GameObject player = GameObject.Find("Player");
			if (player != null)
			{
				if (gunActive)
				{
					player.GetComponent<PlayerPowers>().gun = true;
				}
				else
				{
					player.GetComponent<PlayerPowers>().gun = false;
				}
			}
		}

	}
}
