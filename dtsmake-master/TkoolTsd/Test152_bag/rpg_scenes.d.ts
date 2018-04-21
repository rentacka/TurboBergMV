// Type definitions for rpg_scenes.js
// Project: [LIBRARY_URL_HERE] 
// Definitions by: [YOUR_NAME_HERE] <[YOUR_URL_HERE]> 
// Definitions: https://github.com/borisyankov/DefinitelyTyped

/**
 * The Superclass of all scene within the game.
 * 
 * @class Scene_Base
 * @constructor
 * @extends Stage
 */
declare interface Scene_Base {
		
	/**
	 * 
	 * @return  
	 */
	new (): Scene_Base;
}


/**
 * -----------------------------------------------------------------------------
 * Scene_Boot
 * 
 * The scene class for initializing the entire game.
 */
declare interface Scene_Boot {
		
	/**
	 * 
	 * @return  
	 */
	new (): Scene_Boot;
}


/**
 * 
 */
declare namespace Scene_Boot{
		
	/**
	 * 
	 */
	function loadSystemImages(): void;
}

/**
 * -----------------------------------------------------------------------------
 * Scene_Title
 * 
 * The scene class of the title screen.
 */
declare interface Scene_Title {
		
	/**
	 * 
	 * @return  
	 */
	new (): Scene_Title;
}


/**
 * -----------------------------------------------------------------------------
 * Scene_Map
 * 
 * The scene class of the map screen.
 */
declare interface Scene_Map {
		
	/**
	 * 
	 * @return  
	 */
	new (): Scene_Map;
}


/**
 * -----------------------------------------------------------------------------
 * Scene_MenuBase
 * 
 * The superclass of all the menu-type scenes.
 */
declare interface Scene_MenuBase {
		
	/**
	 * 
	 * @return  
	 */
	new (): Scene_MenuBase;
}


/**
 * -----------------------------------------------------------------------------
 * Scene_Menu
 * 
 * The scene class of the menu screen.
 */
declare interface Scene_Menu {
		
	/**
	 * 
	 * @return  
	 */
	new (): Scene_Menu;
}


/**
 * -----------------------------------------------------------------------------
 * Scene_ItemBase
 * 
 * The superclass of Scene_Item and Scene_Skill.
 */
declare interface Scene_ItemBase {
		
	/**
	 * 
	 * @return  
	 */
	new (): Scene_ItemBase;
}


/**
 * -----------------------------------------------------------------------------
 * Scene_Item
 * 
 * The scene class of the item screen.
 */
declare interface Scene_Item {
		
	/**
	 * 
	 * @return  
	 */
	new (): Scene_Item;
}


/**
 * -----------------------------------------------------------------------------
 * Scene_Skill
 * 
 * The scene class of the skill screen.
 */
declare interface Scene_Skill {
		
	/**
	 * 
	 * @return  
	 */
	new (): Scene_Skill;
}


/**
 * -----------------------------------------------------------------------------
 * Scene_Equip
 * 
 * The scene class of the equipment screen.
 */
declare interface Scene_Equip {
		
	/**
	 * 
	 * @return  
	 */
	new (): Scene_Equip;
}


/**
 * -----------------------------------------------------------------------------
 * Scene_Status
 * 
 * The scene class of the status screen.
 */
declare interface Scene_Status {
		
	/**
	 * 
	 * @return  
	 */
	new (): Scene_Status;
}


/**
 * -----------------------------------------------------------------------------
 * Scene_Options
 * 
 * The scene class of the options screen.
 */
declare interface Scene_Options {
		
	/**
	 * 
	 * @return  
	 */
	new (): Scene_Options;
}


/**
 * -----------------------------------------------------------------------------
 * Scene_File
 * 
 * The superclass of Scene_Save and Scene_Load.
 */
declare interface Scene_File {
		
	/**
	 * 
	 * @return  
	 */
	new (): Scene_File;
}


/**
 * -----------------------------------------------------------------------------
 * Scene_Save
 * 
 * The scene class of the save screen.
 */
declare interface Scene_Save {
		
	/**
	 * 
	 * @return  
	 */
	new (): Scene_Save;
}


/**
 * -----------------------------------------------------------------------------
 * Scene_Load
 * 
 * The scene class of the load screen.
 */
declare interface Scene_Load {
		
	/**
	 * 
	 * @return  
	 */
	new (): Scene_Load;
}


/**
 * -----------------------------------------------------------------------------
 * Scene_GameEnd
 * 
 * The scene class of the game end screen.
 */
declare interface Scene_GameEnd {
		
	/**
	 * 
	 * @return  
	 */
	new (): Scene_GameEnd;
}


/**
 * -----------------------------------------------------------------------------
 * Scene_Shop
 * 
 * The scene class of the shop screen.
 */
declare interface Scene_Shop {
		
	/**
	 * 
	 * @return  
	 */
	new (): Scene_Shop;
}


/**
 * -----------------------------------------------------------------------------
 * Scene_Name
 * 
 * The scene class of the name input screen.
 */
declare interface Scene_Name {
		
	/**
	 * 
	 * @return  
	 */
	new (): Scene_Name;
}


/**
 * -----------------------------------------------------------------------------
 * Scene_Debug
 * 
 * The scene class of the debug screen.
 */
declare interface Scene_Debug {
		
	/**
	 * 
	 * @return  
	 */
	new (): Scene_Debug;
}


/**
 * -----------------------------------------------------------------------------
 * Scene_Battle
 * 
 * The scene class of the battle screen.
 */
declare interface Scene_Battle {
		
	/**
	 * 
	 * @return  
	 */
	new (): Scene_Battle;
}


/**
 * -----------------------------------------------------------------------------
 * Scene_Gameover
 * 
 * The scene class of the game over screen.
 */
declare interface Scene_Gameover {
		
	/**
	 * 
	 * @return  
	 */
	new (): Scene_Gameover;
}

