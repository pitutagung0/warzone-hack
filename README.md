# warzone-hack

> Call of Duty Warzone · cheat · esp · aimbot · wallhack · triggerbot

[![.NET 10](https://img.shields.io/badge/.NET-10.0-512BD4)](https://dot.net)
[![Cheat](https://img.shields.io/badge/type-cheat-red)]()
[![Game](https://img.shields.io/badge/game-Call%20of%20Duty%20Warzone-orange)]()
[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](LICENSE)

**warzone-hack** is an external Call of Duty Warzone cheat: ESP, aim assist, triggerbot, recoil, bhop, radar and misc.

tested on latest patch. for research and educational purposes only.

## features

- **ESP** — box, health bar, distance, name tags, skeleton, snaplines
- **Aim Assist** — configurable FOV circle, smooth factor, bone select, recoil compensation
- **TriggerBot** — reaction delay with jitter, burst mode, team check
- **Bunny Hop** — auto-jump on ground flag detect
- **Radar** — force enemy spotted on minimap
- **No Flash** — override flash duration to zero
- **Config** — JSON profiles under %APPDATA%, import/export, hotkeys

## build

requires .NET 10 SDK.

```
dotnet build
```

run:

```
.\build\bin\warzone-hack.Loader\net10.0\wzhack.exe
```

Call of Duty Warzone must be running before you start the loader.

## config

profiles auto-save to `%APPDATA%\warzone-hack\profiles\default.json`.

```json
{
  "aim": {
    "enabled": true,
    "fov": 5.0,
    "smooth": 3.5,
    "bone": "Head",
    "rcs": true
  },
  "esp": {
    "enabled": true,
    "box": true,
    "health": true,
    "skeleton": false,
    "distance": true
  },
  "trigger": {
    "enabled": false,
    "delayMs": 50,
    "jitter": 15,
    "burstCount": 1
  },
  "misc": {
    "bhop": false,
    "noFlash": false,
    "radar": false
  }
}
```

## keybinds

| key | action |
|---|---|
| INSERT | toggle menu |
| F1 | aim assist |
| F2 | esp |
| F3 | triggerbot |
| F4 | bhop |
| MOUSE5 | aim key (hold) |
| HOME | reload config |
| END | panic — clean exit |

## anti-cheat

targets **Ricochet**. no bypass included.
detection is expected without additional evasion layers.

## disclaimer

educational / research project for game hacking concepts.
not affiliated with the developers of Call of Duty Warzone.
don't use in online matchmaking — you **will** get banned.


---

## Topics

![warzone](https://img.shields.io/badge/warzone-111827?style=flat-square) ![warzone-hack](https://img.shields.io/badge/warzone%20hack-111827?style=flat-square) ![call-of-duty](https://img.shields.io/badge/call%20of%20duty-111827?style=flat-square) ![cod](https://img.shields.io/badge/cod-111827?style=flat-square) ![cheat](https://img.shields.io/badge/cheat-111827?style=flat-square) ![hack](https://img.shields.io/badge/hack-111827?style=flat-square) ![aimbot](https://img.shields.io/badge/aimbot-111827?style=flat-square) ![esp](https://img.shields.io/badge/esp-111827?style=flat-square)

`warzone` `warzone-hack` `call-of-duty` `cod` `cheat` `hack` `aimbot` `esp` `no-recoil` `unlock-all` `ricochet` `game-hacking` `free` `csharp`

Search: warzone-hack · warzone · hack · aimbot · esp · Call of Duty Warzone hack — silent aim, UAV ESP, no recoil, unlock all. Ricochet anti-cheat notes.

---

<sub>Call of Duty Warzone hack — silent aim, UAV ESP, no recoil, unlock all. Ricochet anti-cheat notes.</sub>
