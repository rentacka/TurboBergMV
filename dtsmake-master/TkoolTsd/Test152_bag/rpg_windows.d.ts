// Type definitions for rpg_windows.js
// Project: [LIBRARY_URL_HERE] 
// Definitions by: [YOUR_NAME_HERE] <[YOUR_URL_HERE]> 
// Definitions: https://github.com/borisyankov/DefinitelyTyped

/**
 * -----------------------------------------------------------------------------
 * Window_Base
 * 
 * The superclass of all windows within the game.
 */
declare interface Window_Base {
		
	/**
	 * 
	 * @return  
	 */
	new (): Window_Base;
}


/**
 * 
 */
declare namespace Window_Base{
		
	/**
	 * 
	 */
	export var _iconWidth : number;
		
	/**
	 * 
	 */
	export var _iconHeight : number;
		
	/**
	 * 
	 */
	export var _faceWidth : number;
		
	/**
	 * 
	 */
	export var _faceHeight : number;
}

/**
 * -----------------------------------------------------------------------------
 * Window_Selectable
 * 
 * The window class with cursor movement and scroll functions.
 */
declare interface Window_Selectable {
		
	/**
	 * 
	 * @return  
	 */
	new (): Window_Selectable;
}


/**
 * -----------------------------------------------------------------------------
 * Window_Command
 * 
 * The superclass of windows for selecting a command.
 */
declare interface Window_Command {
		
	/**
	 * 
	 * @return  
	 */
	new (): Window_Command;
}


/**
 * -----------------------------------------------------------------------------
 * Window_HorzCommand
 * 
 * The command window for the horizontal selection format.
 */
declare interface Window_HorzCommand {
		
	/**
	 * 
	 * @return  
	 */
	new (): Window_HorzCommand;
}


/**
 * -----------------------------------------------------------------------------
 * Window_Help
 * 
 * The window for displaying the description of the selected item.
 */
declare interface Window_Help {
		
	/**
	 * 
	 * @return  
	 */
	new (): Window_Help;
}


/**
 * -----------------------------------------------------------------------------
 * Window_Gold
 * 
 * The window for displaying the party's gold.
 */
declare interface Window_Gold {
		
	/**
	 * 
	 * @return  
	 */
	new (): Window_Gold;
}


/**
 * -----------------------------------------------------------------------------
 * Window_MenuCommand
 * 
 * The window for selecting a command on the menu screen.
 */
declare interface Window_MenuCommand {
		
	/**
	 * 
	 * @return  
	 */
	new (): Window_MenuCommand;
}


/**
 * 
 */
declare namespace Window_MenuCommand{
		
	/**
	 * 
	 */
	function initCommandPosition(): void;
}

/**
 * -----------------------------------------------------------------------------
 * Window_MenuStatus
 * 
 * The window for displaying party member status on the menu screen.
 */
declare interface Window_MenuStatus {
		
	/**
	 * 
	 * @return  
	 */
	new (): Window_MenuStatus;
}


/**
 * -----------------------------------------------------------------------------
 * Window_MenuActor
 * 
 * The window for selecting a target actor on the item and skill screens.
 */
declare interface Window_MenuActor {
		
	/**
	 * 
	 * @return  
	 */
	new (): Window_MenuActor;
}


/**
 * -----------------------------------------------------------------------------
 * Window_ItemCategory
 * 
 * The window for selecting a category of items on the item and shop screens.
 */
declare interface Window_ItemCategory {
		
	/**
	 * 
	 * @return  
	 */
	new (): Window_ItemCategory;
}


/**
 * -----------------------------------------------------------------------------
 * Window_ItemList
 * 
 * The window for selecting an item on the item screen.
 */
declare interface Window_ItemList {
		
	/**
	 * 
	 * @return  
	 */
	new (): Window_ItemList;
}


/**
 * -----------------------------------------------------------------------------
 * Window_SkillType
 * 
 * The window for selecting a skill type on the skill screen.
 */
declare interface Window_SkillType {
		
	/**
	 * 
	 * @return  
	 */
	new (): Window_SkillType;
}


/**
 * -----------------------------------------------------------------------------
 * Window_SkillStatus
 * 
 * The window for displaying the skill user's status on the skill screen.
 */
declare interface Window_SkillStatus {
		
	/**
	 * 
	 * @return  
	 */
	new (): Window_SkillStatus;
}


/**
 * -----------------------------------------------------------------------------
 * Window_SkillList
 * 
 * The window for selecting a skill on the skill screen.
 */
declare interface Window_SkillList {
		
	/**
	 * 
	 * @return  
	 */
	new (): Window_SkillList;
}


/**
 * -----------------------------------------------------------------------------
 * Window_EquipStatus
 * 
 * The window for displaying parameter changes on the equipment screen.
 */
declare interface Window_EquipStatus {
		
	/**
	 * 
	 * @return  
	 */
	new (): Window_EquipStatus;
}


/**
 * -----------------------------------------------------------------------------
 * Window_EquipCommand
 * 
 * The window for selecting a command on the equipment screen.
 */
declare interface Window_EquipCommand {
		
	/**
	 * 
	 * @return  
	 */
	new (): Window_EquipCommand;
}


/**
 * -----------------------------------------------------------------------------
 * Window_EquipSlot
 * 
 * The window for selecting an equipment slot on the equipment screen.
 */
declare interface Window_EquipSlot {
		
	/**
	 * 
	 * @return  
	 */
	new (): Window_EquipSlot;
}


/**
 * -----------------------------------------------------------------------------
 * Window_EquipItem
 * 
 * The window for selecting an equipment item on the equipment screen.
 */
declare interface Window_EquipItem {
		
	/**
	 * 
	 * @return  
	 */
	new (): Window_EquipItem;
}


/**
 * -----------------------------------------------------------------------------
 * Window_Status
 * 
 * The window for displaying full status on the status screen.
 */
declare interface Window_Status {
		
	/**
	 * 
	 * @return  
	 */
	new (): Window_Status;
}


/**
 * -----------------------------------------------------------------------------
 * Window_Options
 * 
 * The window for changing various settings on the options screen.
 */
declare interface Window_Options {
		
	/**
	 * 
	 * @return  
	 */
	new (): Window_Options;
}


/**
 * -----------------------------------------------------------------------------
 * Window_SavefileList
 * 
 * The window for selecting a save file on the save and load screens.
 */
declare interface Window_SavefileList {
		
	/**
	 * 
	 * @return  
	 */
	new (): Window_SavefileList;
}


/**
 * -----------------------------------------------------------------------------
 * Window_ShopCommand
 * 
 * The window for selecting buy/sell on the shop screen.
 */
declare interface Window_ShopCommand {
		
	/**
	 * 
	 * @return  
	 */
	new (): Window_ShopCommand;
}


/**
 * -----------------------------------------------------------------------------
 * Window_ShopBuy
 * 
 * The window for selecting an item to buy on the shop screen.
 */
declare interface Window_ShopBuy {
		
	/**
	 * 
	 * @return  
	 */
	new (): Window_ShopBuy;
}


/**
 * -----------------------------------------------------------------------------
 * Window_ShopSell
 * 
 * The window for selecting an item to sell on the shop screen.
 */
declare interface Window_ShopSell {
		
	/**
	 * 
	 * @return  
	 */
	new (): Window_ShopSell;
}


/**
 * -----------------------------------------------------------------------------
 * Window_ShopNumber
 * 
 * The window for inputting quantity of items to buy or sell on the shop
 * screen.
 */
declare interface Window_ShopNumber {
		
	/**
	 * 
	 * @return  
	 */
	new (): Window_ShopNumber;
}


/**
 * -----------------------------------------------------------------------------
 * Window_ShopStatus
 * 
 * The window for displaying number of items in possession and the actor's
 * equipment on the shop screen.
 */
declare interface Window_ShopStatus {
		
	/**
	 * 
	 * @return  
	 */
	new (): Window_ShopStatus;
}


/**
 * -----------------------------------------------------------------------------
 * Window_NameEdit
 * 
 * The window for editing an actor's name on the name input screen.
 */
declare interface Window_NameEdit {
		
	/**
	 * 
	 * @return  
	 */
	new (): Window_NameEdit;
}


/**
 * -----------------------------------------------------------------------------
 * Window_NameInput
 * 
 * The window for selecting text characters on the name input screen.
 */
declare interface Window_NameInput {
		
	/**
	 * 
	 * @return  
	 */
	new (): Window_NameInput;
}


/**
 * 
 */
declare namespace Window_NameInput{
		
	/**
	 * 
	 */
	export var LATIN1 : Array<string>;
		
	/**
	 * 
	 */
	export var LATIN2 : Array<string>;
		
	/**
	 * 
	 */
	export var RUSSIA : Array<string>;
		
	/**
	 * 
	 */
	export var JAPAN1 : Array<string>;
		
	/**
	 * 
	 */
	export var JAPAN2 : Array<string>;
		
	/**
	 * 
	 */
	export var JAPAN3 : Array<string>;
}

/**
 * -----------------------------------------------------------------------------
 * Window_ChoiceList
 * 
 * The window used for the event command [Show Choices].
 */
declare interface Window_ChoiceList {
		
	/**
	 * 
	 * @return  
	 */
	new (): Window_ChoiceList;
}


/**
 * -----------------------------------------------------------------------------
 * Window_NumberInput
 * 
 * The window used for the event command [Input Number].
 */
declare interface Window_NumberInput {
		
	/**
	 * 
	 * @return  
	 */
	new (): Window_NumberInput;
}


/**
 * -----------------------------------------------------------------------------
 * Window_EventItem
 * 
 * The window used for the event command [Select Item].
 */
declare interface Window_EventItem {
		
	/**
	 * 
	 * @return  
	 */
	new (): Window_EventItem;
}


/**
 * -----------------------------------------------------------------------------
 * Window_Message
 * 
 * The window for displaying text messages.
 */
declare interface Window_Message {
		
	/**
	 * 
	 * @return  
	 */
	new (): Window_Message;
}


/**
 * -----------------------------------------------------------------------------
 * Window_ScrollText
 * 
 * The window for displaying scrolling text. No frame is displayed, but it
 * is handled as a window for convenience.
 */
declare interface Window_ScrollText {
		
	/**
	 * 
	 * @return  
	 */
	new (): Window_ScrollText;
}


/**
 * -----------------------------------------------------------------------------
 * Window_MapName
 * 
 * The window for displaying the map name on the map screen.
 */
declare interface Window_MapName {
		
	/**
	 * 
	 * @return  
	 */
	new (): Window_MapName;
}


/**
 * -----------------------------------------------------------------------------
 * Window_BattleLog
 * 
 * The window for displaying battle progress. No frame is displayed, but it is
 * handled as a window for convenience.
 */
declare interface Window_BattleLog {
		
	/**
	 * 
	 * @return  
	 */
	new (): Window_BattleLog;
}


/**
 * -----------------------------------------------------------------------------
 * Window_PartyCommand
 * 
 * The window for selecting whether to fight or escape on the battle screen.
 */
declare interface Window_PartyCommand {
		
	/**
	 * 
	 * @return  
	 */
	new (): Window_PartyCommand;
}


/**
 * -----------------------------------------------------------------------------
 * Window_ActorCommand
 * 
 * The window for selecting an actor's action on the battle screen.
 */
declare interface Window_ActorCommand {
		
	/**
	 * 
	 * @return  
	 */
	new (): Window_ActorCommand;
}


/**
 * -----------------------------------------------------------------------------
 * Window_BattleStatus
 * 
 * The window for displaying the status of party members on the battle screen.
 */
declare interface Window_BattleStatus {
		
	/**
	 * 
	 * @return  
	 */
	new (): Window_BattleStatus;
}


/**
 * -----------------------------------------------------------------------------
 * Window_BattleActor
 * 
 * The window for selecting a target actor on the battle screen.
 */
declare interface Window_BattleActor {
		
	/**
	 * 
	 * @return  
	 */
	new (): Window_BattleActor;
}


/**
 * -----------------------------------------------------------------------------
 * Window_BattleEnemy
 * 
 * The window for selecting a target enemy on the battle screen.
 */
declare interface Window_BattleEnemy {
		
	/**
	 * 
	 * @return  
	 */
	new (): Window_BattleEnemy;
}


/**
 * -----------------------------------------------------------------------------
 * Window_BattleSkill
 * 
 * The window for selecting a skill to use on the battle screen.
 */
declare interface Window_BattleSkill {
		
	/**
	 * 
	 * @return  
	 */
	new (): Window_BattleSkill;
}


/**
 * -----------------------------------------------------------------------------
 * Window_BattleItem
 * 
 * The window for selecting an item to use on the battle screen.
 */
declare interface Window_BattleItem {
		
	/**
	 * 
	 * @return  
	 */
	new (): Window_BattleItem;
}


/**
 * -----------------------------------------------------------------------------
 * Window_TitleCommand
 * 
 * The window for selecting New Game/Continue on the title screen.
 */
declare interface Window_TitleCommand {
		
	/**
	 * 
	 * @return  
	 */
	new (): Window_TitleCommand;
}


/**
 * 
 */
declare namespace Window_TitleCommand{
		
	/**
	 * 
	 */
	function initCommandPosition(): void;
}

/**
 * -----------------------------------------------------------------------------
 * Window_GameEnd
 * 
 * The window for selecting "Go to Title" on the game end screen.
 */
declare interface Window_GameEnd {
		
	/**
	 * 
	 * @return  
	 */
	new (): Window_GameEnd;
}


/**
 * -----------------------------------------------------------------------------
 * Window_DebugRange
 * 
 * The window for selecting a block of switches/variables on the debug screen.
 */
declare interface Window_DebugRange {
		
	/**
	 * 
	 * @return  
	 */
	new (): Window_DebugRange;
}


/**
 * 
 */
declare namespace Window_DebugRange{
		
	/**
	 * 
	 */
	export var lastTopRow : number;
		
	/**
	 * 
	 */
	export var lastIndex : number;
}

/**
 * -----------------------------------------------------------------------------
 * Window_DebugEdit
 * 
 * The window for displaying switches and variables on the debug screen.
 */
declare interface Window_DebugEdit {
		
	/**
	 * 
	 * @return  
	 */
	new (): Window_DebugEdit;
}

