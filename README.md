# CustomGifts

## About
The CustomGifts plugin is designed to enhance gameplay by providing custom gifts to players when they perform certain actions.

## How the CustomGifts Plugin Works
The CustomGifts plugin uses the EXILED Events framework to handle various events in the game. When certain actions are triggered, such as a player escaping SCP-106 Pocket Dimensions, the plugin will give a random gift from the list of available items. If the player does not have an open inventory slot, the plugin will give ammo instead.


## Configuration
Default:
| Option           | Default Value | Description                            |
| ---------------- | ------------- | -------------------------------------- |
| `IsEnabled`      | `true`        | Specifies whether the plugin is enabled |
| `Debug`          | `false`       | Enables or disables debugging mode      |
| `CanGiftsBeItems`| `true`        | Allows gifts to be items                |
| `CanGiftsBeAmmo` | `True`       | Allows gifts to be ammo                 |
| `ItemsTypes`     | `{}`          | A dictionary of available items for gifting, along with their corresponding chances |
| `AmmoTypes`      | `{}`          | A dictionary of available ammo types for gifting, along with their corresponding chances |

## Installation
To use the CustomGifts, follow these steps:
1. Download the plugin files.
2. Add the `CustomGifts` folder to your plugin folder in your server's Exiled plugins directory.
3. Start or restart your server.

## Contributions
Feel free to contribute to this project by creating pull requests or reporting/fixing issues

## Credits
This plugin was created by Dashtiss.
