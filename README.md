[![Github All Releases](https://img.shields.io/github/downloads/xRoier/SCP-1162-EXILED/total?color=blueviolet&style=for-the-badge)]()
# SCP-1162-EXILED

Turn 173 spawn into SCP-1162.
If you drop an item inside the "cage"/room of Scp-173 you will get another one.

# Config
```
scp1162:
# Is the plugin enabled?
  is_enabled: true
  # Use Hints instead of Broadcast?
  use_hints: true
  # Use Old SCP-173 Spawn in Light Containment?
  use_old173_spawn: true
  # Change the message that displays when you drop an item through SCP-1162.
  item_drop_message: <i>You try to drop the item through <color=yellow>SCP-1162</color> to get another...</i>
  item_drop_message_duration: 5
  # The list of possible items which can be dropped
  item_drops:
	- KeycardScientist
	- KeycardResearchCoordinator
	- KeycardZoneManager
	- KeycardGuard
	- KeycardMTFPrivate
	- KeycardContainmentEngineer
	- KeycardMTFOperative
	- KeycardMTFCaptain
	- KeycardFacilityManager
	- KeycardChaosInsurgency
	- KeycardO5
	- Radio
	- GunCOM15
	- Medkit
	- Flashlight
	- MicroHID
	- SCP500
	- SCP207
	- Ammo12gauge
	- GunE11SR
	- GunCrossvec
	- Ammo556x45
	- GunFSP9
	- GunLogicer
	- GrenadeHE
	- GrenadeFlash
	- Ammo44cal
	- Ammo762x39
	- Ammo9x19
	- GunCOM18
	- SCP018
	- SCP268
	- Adrenaline
	- Painkillers
	- Coin
	- ArmorLight
	- ArmorCombat
	- ArmorHeavy
	- GunRevolver
	- GunAK
	- GunShotgun
	- SCP330
	- SCP2176
	- SCP244a
	- SCP244b
	- SCP1853
	- ParticleDisruptor
	- GunCom45
	- SCP1576
	- Jailbird
	- AntiSCP207
	- GunFRMG0
	- GunA7
	- Lantern
```


# Installation

**[EXILED 6.0.0](https://github.com/galaxy119/EXILED) must be installed for this to work.**

Place the "SCP1162.dll" file in your Plugins folder.
Windows: ``%appdata%/EXILED/Plugins``.
Linux: ``.config/EXILED/Plugins``.
