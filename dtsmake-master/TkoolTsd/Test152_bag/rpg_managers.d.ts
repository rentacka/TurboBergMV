// Type definitions for rpg_managers.js
// Project: [LIBRARY_URL_HERE] 
// Definitions by: [YOUR_NAME_HERE] <[YOUR_URL_HERE]> 
// Definitions: https://github.com/borisyankov/DefinitelyTyped
///<reference path='rpg_data_interface.d.ts'/>
///<reference path='rpg_data_map_interface.d.ts'/>
///<reference path='rpg_objects.d.ts'/>

declare namespace DataManager{
	// DataManager._databaseFiles.<i>
	
	/**
	 * 
	 */
	interface _databaseFilesI {
				
		/**
		 * 
		 */
		name : string;
				
		/**
		 * 
		 */
		src : string;
	}
}
declare namespace DataManager{
	// DataManager.onLoad.!0
	
	/**
	 * 
	 */
	interface OnLoad0 {
				
		/**
		 * 
		 */
		meta : /*no type*/{};
	}
}
declare namespace DataManager{
	// DataManager.loadGlobalInfo.!ret
	type LoadGlobalInfoRet = Array<any>;
}
declare namespace DataManager{
	// DataManager.saveGlobalInfo.!0
	
	/**
	 * 
	 */
	interface SaveGlobalInfo0 {
				
		/**
		 * 
		 */
        info: Array</* DataManager.loadSavefileImages.!0 */ any>;
	}
}
declare namespace DataManager{
	// DataManager.loadSavefileImages.!0
	
	/**
	 * 
	 */
	interface LoadSavefileImages0 {
				
		/**
		 * 
		 */
		globalId : string;
				
		/**
		 * 
		 */
		timestamp : number;
	}
}
declare namespace DataManager{
	// DataManager.makeSaveContents.!ret
	
	/**
	 * A save data does not contain $gameTemp, $gameMessage, and $gameTroop.
	 */
	interface MakeSaveContentsRet {
	}
}
declare namespace ConfigManager{
	// ConfigManager.makeData.!ret
	
	/**
	 * 
	 */
	interface MakeDataRet {
				
		/**
		 * 
		 */
		alwaysDash : boolean;
				
		/**
		 * 
		 */
		commandRemember : boolean;
				
		/**
		 * 
		 */
		bgmVolume : number;
				
		/**
		 * 
		 */
		bgsVolume : number;
				
		/**
		 * 
		 */
		meVolume : number;
				
		/**
		 * 
		 */
		seVolume : number;
	}
}
declare namespace ImageManager{
	// ImageManager.loadAnimation.!ret
	
	/**
	 * 
	 */
	interface LoadAnimationRet {
				
		/**
		 * 
		 */
		smooth : boolean;
	}
}
declare namespace ImageManager{
	// ImageManager.loadEmptyBitmap.!ret
	
	/**
	 * 
	 */
	interface LoadEmptyBitmapRet {
				
		/**
		 * 
		 */
		smooth : boolean;
	}
}
declare namespace ImageManager{
	// ImageManager.reserveAnimation.!ret
	
	/**
	 * 
	 */
	interface ReserveAnimationRet {
				
		/**
		 * 
		 */
		smooth : boolean;
	}
}
declare namespace AudioManager{
	// AudioManager._staticBuffers.<i>
	
	/**
	 * 
	 */
	interface _staticBuffersI {
				
		/**
		 * 
		 */
		volume : number;
				
		/**
		 * 
		 */
		pitch : number;
				
		/**
		 * 
		 */
		pan : number;
	}
}
declare namespace AudioManager{
	// AudioManager.playBgm.!0
	
	/**
	 * 
	 */
	interface PlayBgm0 {
				
		/**
		 * 
		 */
		pos : number;
	}
}
declare namespace AudioManager{
	// AudioManager.playBgs.!0
	
	/**
	 * 
	 */
	interface PlayBgs0 {
				
		/**
		 * 
		 */
		pos : number;
	}
}
declare namespace AudioManager{
	// AudioManager.makeEmptyAudioObject.!ret
	
	/**
	 * 
	 */
	interface MakeEmptyAudioObjectRet {
				
		/**
		 * 
		 */
		name : string;
				
		/**
		 * 
		 */
		volume : number;
				
		/**
		 * 
		 */
		pitch : number;
	}
}
declare namespace TextManager{
	// TextManager.getter.!ret
	
	/**
	 * 
	 */
	interface GetterRet {
				
		/**
		 * 
		 */
		get(): void;
				
		/**
		 * 
		 */
		configurable : boolean;
	}
}

/**
 * -----------------------------------------------------------------------------
 * DataManager
 * 
 * The static class that manages the database and game objects.
 */
declare interface DataManager {
		
	/**
	 * 
	 * @return  
	 */
	new (): DataManager;
}


/**
 * 
 */
declare namespace DataManager{
		
	/**
	 * 
	 */
	export var _globalId : string;
		
	/**
	 * 
	 */
	export var _lastAccessedId : number;
		
	/**
	 * 
	 */
	export var _errorUrl : string;
		
	/**
	 * 
	 */
	export var _databaseFiles : Array</* DataManager._databaseFilesI */ any>;
		
	/**
	 * 
	 */
	function loadDatabase(): void;
		
	/**
	 * 
	 * @param name 
	 * @param src 
	 */
	function loadDataFile(name : string, src : string): void;
		
	/**
	 * 
	 * @return  
	 */
	function isDatabaseLoaded(): boolean;
		
	/**
	 * 
	 * @param mapId 
	 */
	function loadMapData(mapId : any): void;
		
	/**
	 * 
	 */
	function makeEmptyMap(): void;
		
	/**
	 * 
	 * @return  
	 */
	function isMapLoaded(): boolean;
		
	/**
	 * 
	 * @param object 
	 */
	function onLoad(object : DataManager.OnLoad0): void;
		
	/**
	 * 
	 * @param data 
	 */
	function extractMetadata(data : /* DataManager.onLoad.!0 */ any): void;
		
	/**
	 * 
	 */
	function checkError(): void;
		
	/**
	 * 
	 */
	function isBattleTest(): void;
		
	/**
	 * 
	 */
	function isEventTest(): void;
		
	/**
	 * 
	 * @param item 
	 * @return  
	 */
	function isSkill(item : any): any;
		
	/**
	 * 
	 * @param item 
	 * @return  
	 */
	function isItem(item : any): any;
		
	/**
	 * 
	 * @param item 
	 * @return  
	 */
	function isWeapon(item : any): any;
		
	/**
	 * 
	 * @param item 
	 * @return  
	 */
	function isArmor(item : any): any;
		
	/**
	 * 
	 */
	function createGameObjects(): void;
		
	/**
	 * 
	 */
	function setupNewGame(): void;
		
	/**
	 * 
	 */
	function setupBattleTest(): void;
		
	/**
	 * 
	 */
	function setupEventTest(): void;
		
	/**
	 * 
	 * @return  
	 */
	function loadGlobalInfo(): DataManager.LoadGlobalInfoRet;
		
	/**
	 * 
	 * @param info 
	 */
	function saveGlobalInfo(info : DataManager.SaveGlobalInfo0): void;
		
	/**
	 * 
	 * @param savefileId 
	 * @return  
	 */
	function isThisGameFile(savefileId : number): boolean;
		
	/**
	 * 
	 * @return  
	 */
	function isAnySavefileExists(): boolean;
		
	/**
	 * 
	 * @return  
	 */
	function latestSavefileId(): number;
		
	/**
	 * 
	 */
	function loadAllSavefileImages(): void;
		
	/**
	 * 
	 * @param info 
	 */
	function loadSavefileImages(info : DataManager.LoadSavefileImages0): void;
		
	/**
	 * 
	 * @return  
	 */
	function maxSavefiles(): number;
		
	/**
	 * 
	 * @param savefileId 
	 * @return  
	 */
	function saveGame(savefileId : any): boolean;
		
	/**
	 * 
	 * @param savefileId 
	 * @return  
	 */
	function loadGame(savefileId : any): boolean;
		
	/**
	 * 
	 * @param savefileId 
	 */
	function loadSavefileInfo(savefileId : any): void;
		
	/**
	 * 
	 * @return  
	 */
	function lastAccessedSavefileId(): /* !this._lastAccessedId */ any;
		
	/**
	 * 
	 * @param savefileId 
	 * @return  
	 */
	function saveGameWithoutRescue(savefileId : any): boolean;
		
	/**
	 * 
	 * @param savefileId 
	 * @return  
	 */
	function loadGameWithoutRescue(savefileId : any): boolean;
		
	/**
	 * 
	 */
	function selectSavefileForNewGame(): void;
		
	/**
	 * 
	 * @return  
	 */
	function makeSavefileInfo(): /* DataManager.loadSavefileImages.!0 */ any;
		
	/**
	 * 
	 * @return  
	 */
	function makeSaveContents(): DataManager.MakeSaveContentsRet;
		
	/**
	 * 
	 * @param contents 
	 */
	function extractSaveContents(contents : any): void;
}


/**
 * -----------------------------------------------------------------------------
 * ConfigManager
 * 
 * The static class that manages the configuration data.
 */
declare interface ConfigManager {
		
	/**
	 * 
	 * @return  
	 */
	new (): ConfigManager;
}


/**
 * 
 */
declare namespace ConfigManager{
		
	/**
	 * 
	 */
	export var alwaysDash : boolean;
		
	/**
	 * 
	 */
	export var commandRemember : boolean;
		
	/**
	 * 
	 */
	export var bgmVolume : number;
		
	/**
	 * 
	 */
	export var bgsVolume : number;
		
	/**
	 * 
	 */
	export var meVolume : number;
		
	/**
	 * 
	 */
	export var seVolume : number;
		
	/**
	 * 
	 */
	function load(): void;
		
	/**
	 * 
	 */
	function save(): void;
		
	/**
	 * 
	 * @return  
	 */
	function makeData(): ConfigManager.MakeDataRet;
		
	/**
	 * 
	 * @param config 
	 */
	function applyData(config : any): void;
		
	/**
	 * 
	 * @param config 
	 * @param name 
	 * @return  
	 */
	function readFlag(config : any, name : string): boolean;
		
	/**
	 * 
	 * @param config 
	 * @param name 
	 * @return  
	 */
	function readVolume(config : any, name : string): number;
}

/**
 * -----------------------------------------------------------------------------
 * StorageManager
 * 
 * The static class that manages storage for saving game data.
 */
declare interface StorageManager {
		
	/**
	 * 
	 * @return  
	 */
	new (): StorageManager;
}


/**
 * 
 */
declare namespace StorageManager{
		
	/**
	 * 
	 * @param savefileId 
	 * @param json 
	 */
	function save(savefileId : number, json : string): void;
		
	/**
	 * 
	 * @param savefileId 
	 */
	function load(savefileId : number): void;
		
	/**
	 * 
	 * @param savefileId 
	 * @return  
	 */
	function exists(savefileId : number): boolean;
		
	/**
	 * 
	 * @param savefileId 
	 */
	function remove(savefileId : any): void;
		
	/**
	 * 
	 * @param savefileId 
	 */
	function backup(savefileId : any): void;
		
	/**
	 * 
	 * @param savefileId 
	 * @return  
	 */
	function backupExists(savefileId : any): boolean;
		
	/**
	 * 
	 * @param savefileId 
	 */
	function cleanBackup(savefileId : any): void;
		
	/**
	 * 
	 * @param savefileId 
	 */
	function restoreBackup(savefileId : any): void;
		
	/**
	 * 
	 */
	function isLocalMode(): void;
		
	/**
	 * 
	 * @param savefileId 
	 * @param json 
	 */
	function saveToLocalFile(savefileId : number, json : string): void;
		
	/**
	 * 
	 * @param savefileId 
	 */
	function loadFromLocalFile(savefileId : number): void;
		
	/**
	 * 
	 * @param savefileId 
	 */
	function loadFromLocalBackupFile(savefileId : any): void;
		
	/**
	 * 
	 * @param savefileId 
	 */
	function localFileBackupExists(savefileId : any): void;
		
	/**
	 * 
	 * @param savefileId 
	 */
	function localFileExists(savefileId : number): void;
		
	/**
	 * 
	 * @param savefileId 
	 */
	function removeLocalFile(savefileId : any): void;
		
	/**
	 * 
	 * @param savefileId 
	 * @param json 
	 */
	function saveToWebStorage(savefileId : number, json : string): void;
		
	/**
	 * 
	 * @param savefileId 
	 */
	function loadFromWebStorage(savefileId : number): void;
		
	/**
	 * 
	 * @param savefileId 
	 */
	function loadFromWebStorageBackup(savefileId : any): void;
		
	/**
	 * 
	 * @param savefileId 
	 * @return  
	 */
	function webStorageBackupExists(savefileId : any): boolean;
		
	/**
	 * 
	 * @param savefileId 
	 * @return  
	 */
	function webStorageExists(savefileId : number): boolean;
		
	/**
	 * 
	 * @param savefileId 
	 */
	function removeWebStorage(savefileId : any): void;
		
	/**
	 * 
	 */
	function localFileDirectoryPath(): void;
		
	/**
	 * 
	 * @param savefileId 
	 * @return  
	 */
	function localFilePath(savefileId : number): string;
		
	/**
	 * 
	 * @param savefileId 
	 * @return  
	 */
	function webStorageKey(savefileId : number): string;
}

/**
 * -----------------------------------------------------------------------------
 * ImageManager
 * 
 * The static class that loads images, creates bitmap objects and retains them.
 */
declare interface ImageManager {
		
	/**
	 * 
	 * @return  
	 */
	new (): ImageManager;
}


/**
 * 
 */
declare namespace ImageManager{
		
	/**
	 * 
	 * @param path 
	 * @param hue 
	 * @return  
	 */
	function _generateCacheKey(path : string, hue : number): string;
		
	/**
	 * 
	 * @param filename 
	 * @param hue 
	 * @return  
	 */
	function loadAnimation(filename : any, hue : any): ImageManager.LoadAnimationRet;
		
	/**
	 * 
	 * @param filename 
	 * @param hue 
	 * @return  
	 */
	function loadBattleback1(filename : any, hue : any): /* ImageManager.loadAnimation.!ret */ any;
		
	/**
	 * 
	 * @param filename 
	 * @param hue 
	 * @return  
	 */
	function loadBattleback2(filename : any, hue : any): /* ImageManager.loadAnimation.!ret */ any;
		
	/**
	 * 
	 * @param filename 
	 * @param hue 
	 * @return  
	 */
	function loadEnemy(filename : any, hue : any): /* ImageManager.loadAnimation.!ret */ any;
		
	/**
	 * 
	 * @param filename 
	 * @param hue 
	 * @return  
	 */
	function loadCharacter(filename : any, hue : any): /* ImageManager.loadAnimation.!ret */ any;
		
	/**
	 * 
	 * @param filename 
	 * @param hue 
	 * @return  
	 */
	function loadFace(filename : any, hue : any): /* ImageManager.loadAnimation.!ret */ any;
		
	/**
	 * 
	 * @param filename 
	 * @param hue 
	 * @return  
	 */
	function loadParallax(filename : any, hue : any): /* ImageManager.loadAnimation.!ret */ any;
		
	/**
	 * 
	 * @param filename 
	 * @param hue 
	 * @return  
	 */
	function loadPicture(filename : any, hue : any): /* ImageManager.loadAnimation.!ret */ any;
		
	/**
	 * 
	 * @param filename 
	 * @param hue 
	 * @return  
	 */
	function loadSvActor(filename : any, hue : any): /* ImageManager.loadAnimation.!ret */ any;
		
	/**
	 * 
	 * @param filename 
	 * @param hue 
	 * @return  
	 */
	function loadSvEnemy(filename : any, hue : any): /* ImageManager.loadAnimation.!ret */ any;
		
	/**
	 * 
	 * @param filename 
	 * @param hue 
	 * @return  
	 */
	function loadSystem(filename : any, hue : any): /* ImageManager.loadAnimation.!ret */ any;
		
	/**
	 * 
	 * @param filename 
	 * @param hue 
	 * @return  
	 */
	function loadTileset(filename : any, hue : any): /* ImageManager.loadAnimation.!ret */ any;
		
	/**
	 * 
	 * @param filename 
	 * @param hue 
	 * @return  
	 */
	function loadTitle1(filename : any, hue : any): /* ImageManager.loadAnimation.!ret */ any;
		
	/**
	 * 
	 * @param filename 
	 * @param hue 
	 * @return  
	 */
	function loadTitle2(filename : any, hue : any): /* ImageManager.loadAnimation.!ret */ any;
		
	/**
	 * 
	 * @param folder 
	 * @param filename 
	 * @param hue 
	 * @param smooth 
	 * @return  
	 */
	function loadBitmap(folder : string, filename : any, hue : any, smooth : boolean): /* ImageManager.loadAnimation.!ret */ any;
		
	/**
	 * 
	 * @return  
	 */
	function loadEmptyBitmap(): ImageManager.LoadEmptyBitmapRet;
		
	/**
	 * 
	 * @param path 
	 * @param hue 
	 */
	function loadNormalBitmap(path : string, hue : number): void;
		
	/**
	 * 
	 */
	function clear(): void;
		
	/**
	 * 
	 */
	function isReady(): void;
		
	/**
	 * 
	 * @param filename 
	 */
	function isObjectCharacter(filename : any): void;
		
	/**
	 * 
	 * @param filename 
	 */
	function isBigCharacter(filename : any): void;
		
	/**
	 * 
	 * @param filename 
	 * @return  
	 */
	function isZeroParallax(filename : any): boolean;
		
	/**
	 * 
	 * @param filename 
	 * @param hue 
	 * @param reservationId 
	 * @return  
	 */
	function reserveAnimation(filename : any, hue : any, reservationId : any): ImageManager.ReserveAnimationRet;
		
	/**
	 * 
	 * @param filename 
	 * @param hue 
	 * @param reservationId 
	 * @return  
	 */
	function reserveBattleback1(filename : any, hue : any, reservationId : any): /* ImageManager.reserveAnimation.!ret */ any;
		
	/**
	 * 
	 * @param filename 
	 * @param hue 
	 * @param reservationId 
	 * @return  
	 */
	function reserveBattleback2(filename : any, hue : any, reservationId : any): /* ImageManager.reserveAnimation.!ret */ any;
		
	/**
	 * 
	 * @param filename 
	 * @param hue 
	 * @param reservationId 
	 * @return  
	 */
	function reserveEnemy(filename : any, hue : any, reservationId : any): /* ImageManager.reserveAnimation.!ret */ any;
		
	/**
	 * 
	 * @param filename 
	 * @param hue 
	 * @param reservationId 
	 * @return  
	 */
	function reserveCharacter(filename : any, hue : any, reservationId : any): /* ImageManager.reserveAnimation.!ret */ any;
		
	/**
	 * 
	 * @param filename 
	 * @param hue 
	 * @param reservationId 
	 * @return  
	 */
	function reserveFace(filename : any, hue : any, reservationId : any): /* ImageManager.reserveAnimation.!ret */ any;
		
	/**
	 * 
	 * @param filename 
	 * @param hue 
	 * @param reservationId 
	 * @return  
	 */
	function reserveParallax(filename : any, hue : any, reservationId : any): /* ImageManager.reserveAnimation.!ret */ any;
		
	/**
	 * 
	 * @param filename 
	 * @param hue 
	 * @param reservationId 
	 * @return  
	 */
	function reservePicture(filename : any, hue : any, reservationId : any): /* ImageManager.reserveAnimation.!ret */ any;
		
	/**
	 * 
	 * @param filename 
	 * @param hue 
	 * @param reservationId 
	 * @return  
	 */
	function reserveSvActor(filename : any, hue : any, reservationId : any): /* ImageManager.reserveAnimation.!ret */ any;
		
	/**
	 * 
	 * @param filename 
	 * @param hue 
	 * @param reservationId 
	 * @return  
	 */
	function reserveSvEnemy(filename : any, hue : any, reservationId : any): /* ImageManager.reserveAnimation.!ret */ any;
		
	/**
	 * 
	 * @param filename 
	 * @param hue 
	 * @param reservationId 
	 * @return  
	 */
	function reserveSystem(filename : any, hue : any, reservationId : any): /* ImageManager.reserveAnimation.!ret */ any;
		
	/**
	 * 
	 * @param filename 
	 * @param hue 
	 * @param reservationId 
	 * @return  
	 */
	function reserveTileset(filename : any, hue : any, reservationId : any): /* ImageManager.reserveAnimation.!ret */ any;
		
	/**
	 * 
	 * @param filename 
	 * @param hue 
	 * @param reservationId 
	 * @return  
	 */
	function reserveTitle1(filename : any, hue : any, reservationId : any): /* ImageManager.reserveAnimation.!ret */ any;
		
	/**
	 * 
	 * @param filename 
	 * @param hue 
	 * @param reservationId 
	 * @return  
	 */
	function reserveTitle2(filename : any, hue : any, reservationId : any): /* ImageManager.reserveAnimation.!ret */ any;
		
	/**
	 * 
	 * @param folder 
	 * @param filename 
	 * @param hue 
	 * @param smooth 
	 * @param reservationId 
	 * @return  
	 */
	function reserveBitmap(folder : string, filename : any, hue : any, smooth : boolean, reservationId : any): /* ImageManager.reserveAnimation.!ret */ any;
		
	/**
	 * 
	 * @param path 
	 * @param hue 
	 * @param reservationId 
	 */
	function reserveNormalBitmap(path : string, hue : number, reservationId : any): void;
		
	/**
	 * 
	 * @param reservationId 
	 */
	function releaseReservation(reservationId : any): void;
		
	/**
	 * 
	 * @param reservationId 
	 */
	function setDefaultReservationId(reservationId : any): void;
		
	/**
	 * 
	 * @param filename 
	 * @param hue 
	 * @return  
	 */
	function requestAnimation(filename : any, hue : any): /* ImageManager.loadEmptyBitmap.!ret */ any;
		
	/**
	 * 
	 * @param filename 
	 * @param hue 
	 * @return  
	 */
	function requestBattleback1(filename : any, hue : any): /* ImageManager.loadEmptyBitmap.!ret */ any;
		
	/**
	 * 
	 * @param filename 
	 * @param hue 
	 * @return  
	 */
	function requestBattleback2(filename : any, hue : any): /* ImageManager.loadEmptyBitmap.!ret */ any;
		
	/**
	 * 
	 * @param filename 
	 * @param hue 
	 * @return  
	 */
	function requestEnemy(filename : any, hue : any): /* ImageManager.loadEmptyBitmap.!ret */ any;
		
	/**
	 * 
	 * @param filename 
	 * @param hue 
	 * @return  
	 */
	function requestCharacter(filename : any, hue : any): /* ImageManager.loadEmptyBitmap.!ret */ any;
		
	/**
	 * 
	 * @param filename 
	 * @param hue 
	 * @return  
	 */
	function requestFace(filename : any, hue : any): /* ImageManager.loadEmptyBitmap.!ret */ any;
		
	/**
	 * 
	 * @param filename 
	 * @param hue 
	 * @return  
	 */
	function requestParallax(filename : any, hue : any): /* ImageManager.loadEmptyBitmap.!ret */ any;
		
	/**
	 * 
	 * @param filename 
	 * @param hue 
	 * @return  
	 */
	function requestPicture(filename : any, hue : any): /* ImageManager.loadEmptyBitmap.!ret */ any;
		
	/**
	 * 
	 * @param filename 
	 * @param hue 
	 * @return  
	 */
	function requestSvActor(filename : any, hue : any): /* ImageManager.loadEmptyBitmap.!ret */ any;
		
	/**
	 * 
	 * @param filename 
	 * @param hue 
	 * @return  
	 */
	function requestSvEnemy(filename : any, hue : any): /* ImageManager.loadEmptyBitmap.!ret */ any;
		
	/**
	 * 
	 * @param filename 
	 * @param hue 
	 * @return  
	 */
	function requestSystem(filename : any, hue : any): /* ImageManager.loadEmptyBitmap.!ret */ any;
		
	/**
	 * 
	 * @param filename 
	 * @param hue 
	 * @return  
	 */
	function requestTileset(filename : any, hue : any): /* ImageManager.loadEmptyBitmap.!ret */ any;
		
	/**
	 * 
	 * @param filename 
	 * @param hue 
	 * @return  
	 */
	function requestTitle1(filename : any, hue : any): /* ImageManager.loadEmptyBitmap.!ret */ any;
		
	/**
	 * 
	 * @param filename 
	 * @param hue 
	 * @return  
	 */
	function requestTitle2(filename : any, hue : any): /* ImageManager.loadEmptyBitmap.!ret */ any;
		
	/**
	 * 
	 * @param folder 
	 * @param filename 
	 * @param hue 
	 * @param smooth 
	 * @return  
	 */
	function requestBitmap(folder : string, filename : any, hue : any, smooth : boolean): /* ImageManager.loadEmptyBitmap.!ret */ any;
		
	/**
	 * 
	 * @param path 
	 * @param hue 
	 */
	function requestNormalBitmap(path : string, hue : number): void;
		
	/**
	 * 
	 */
	function update(): void;
		
	/**
	 * 
	 */
	function clearRequest(): void;
}

/**
 * -----------------------------------------------------------------------------
 * AudioManager
 * 
 * The static class that handles BGM, BGS, ME and SE.
 */
declare interface AudioManager {
		
	/**
	 * 
	 * @return  
	 */
	new (): AudioManager;
}


/**
 * 
 */
declare namespace AudioManager{
		
	/**
	 * 
	 */
	export var _masterVolume : number;
		
	/**
	 * 
	 */
	export var _bgmVolume : number;
		
	/**
	 * 
	 */
	export var _bgsVolume : number;
		
	/**
	 * 
	 */
	export var _meVolume : number;
		
	/**
	 * 
	 */
	export var _seVolume : number;
	
	/**
	 * 
	 */
	var _currentBgm : {
				
		/**
		 * 
		 */
		pos : number;
	}
	
	/**
	 * 
	 */
	var _currentBgs : {
				
		/**
		 * 
		 */
		pos : number;
	}
		
	/**
	 * 
	 */
	export var _seBuffers : Array<any>;
		
	/**
	 * 
	 */
	export var _staticBuffers : Array</* AudioManager._staticBuffersI */ any>;
		
	/**
	 * 
	 */
	export var _replayFadeTime : number;
		
	/**
	 * 
	 */
	export var _path : string;
		
	/**
	 * 
	 * @param bgm 
	 * @param pos 
	 */
	function playBgm(bgm : AudioManager.PlayBgm0, pos : number): void;
		
	/**
	 * 
	 * @param bgm 
	 * @param pos 
	 */
	function playEncryptedBgm(bgm : /* BattleManager._mapBgm */ any, pos : number): void;
		
	/**
	 * 
	 * @param url 
	 * @param bgm 
	 * @param pos 
	 */
	function createDecryptBuffer(url : any, bgm : any, pos : any): void;
		
	/**
	 * 
	 * @param bgm 
	 */
	function replayBgm(bgm : /* BattleManager._mapBgm */ any): void;
		
	/**
	 * 
	 * @param bgm 
	 * @return  
	 */
	function isCurrentBgm(bgm : /* BattleManager._mapBgm */ any): /* !this._currentBgm */ any;
		
	/**
	 * 
	 * @param bgm 
	 */
	function updateBgmParameters(bgm : /* BattleManager._mapBgm */ any): void;
		
	/**
	 * 
	 * @param bgm 
	 * @param pos 
	 */
	function updateCurrentBgm(bgm : /* BattleManager._mapBgm */ any, pos : number): void;
		
	/**
	 * 
	 */
	function stopBgm(): void;
		
	/**
	 * 
	 * @param duration 
	 */
	function fadeOutBgm(duration : any): void;
		
	/**
	 * 
	 * @param duration 
	 */
	function fadeInBgm(duration : any): void;
		
	/**
	 * 
	 * @param bgs 
	 * @param pos 
	 */
	function playBgs(bgs : AudioManager.PlayBgs0, pos : number): void;
		
	/**
	 * 
	 * @param bgs 
	 */
	function replayBgs(bgs : /* BattleManager._mapBgs */ any): void;
		
	/**
	 * 
	 * @param bgs 
	 * @return  
	 */
	function isCurrentBgs(bgs : /* BattleManager._mapBgs */ any): /* !this._currentBgs */ any;
		
	/**
	 * 
	 * @param bgs 
	 */
	function updateBgsParameters(bgs : /* BattleManager._mapBgs */ any): void;
		
	/**
	 * 
	 * @param bgs 
	 * @param pos 
	 */
	function updateCurrentBgs(bgs : /* BattleManager._mapBgs */ any, pos : number): void;
		
	/**
	 * 
	 */
	function stopBgs(): void;
		
	/**
	 * 
	 * @param duration 
	 */
	function fadeOutBgs(duration : any): void;
		
	/**
	 * 
	 * @param duration 
	 */
	function fadeInBgs(duration : any): void;
		
	/**
	 * 
	 * @param me 
	 */
	function playMe(me : any): void;
		
	/**
	 * 
	 * @param me 
	 */
	function updateMeParameters(me : any): void;
		
	/**
	 * 
	 * @param duration 
	 */
	function fadeOutMe(duration : any): void;
		
	/**
	 * 
	 */
	function stopMe(): void;
		
	/**
	 * 
	 * @param se 
	 */
	function playSe(se : any): void;
		
	/**
	 * 
	 * @param buffer 
	 * @param se 
	 */
	function updateSeParameters(buffer : /* AudioManager._staticBuffers.<i> */ any, se : any): void;
		
	/**
	 * 
	 */
	function stopSe(): void;
		
	/**
	 * 
	 * @param se 
	 */
	function playStaticSe(se : any): void;
		
	/**
	 * 
	 * @param se 
	 */
	function loadStaticSe(se : any): void;
		
	/**
	 * 
	 * @param se 
	 * @return  
	 */
	function isStaticSe(se : any): boolean;
		
	/**
	 * 
	 */
	function stopAll(): void;
		
	/**
	 * 
	 * @return  
	 */
	function saveBgm(): /* BattleManager._mapBgm */ any;
		
	/**
	 * 
	 * @return  
	 */
	function saveBgs(): /* BattleManager._mapBgs */ any;
		
	/**
	 * 
	 * @return  
	 */
	function makeEmptyAudioObject(): AudioManager.MakeEmptyAudioObjectRet;
		
	/**
	 * 
	 * @param folder 
	 * @param name 
	 */
	function createBuffer(folder : string, name : any): void;
		
	/**
	 * 
	 * @param buffer 
	 * @param configVolume 
	 * @param audio 
	 */
	function updateBufferParameters(buffer : /* AudioManager._staticBuffers.<i> */ any, configVolume : number, audio : /* BattleManager._mapBgm */ any): void;
		
	/**
	 * 
	 * @return  
	 */
	function audioFileExt(): string;
		
	/**
	 * 
	 * @return  
	 */
	function shouldUseHtml5Audio(): boolean;
		
	/**
	 * 
	 */
	function checkErrors(): void;
		
	/**
	 * 
	 * @param webAudio 
	 */
	function checkWebAudioError(webAudio : /* AudioManager._staticBuffers.<i> */ any): void;
}

/**
 * -----------------------------------------------------------------------------
 * SoundManager
 * 
 * The static class that plays sound effects defined in the database.
 */
declare interface SoundManager {
		
	/**
	 * 
	 * @return  
	 */
	new (): SoundManager;
}


/**
 * 
 */
declare namespace SoundManager{
		
	/**
	 * 
	 */
	function preloadImportantSounds(): void;
		
	/**
	 * 
	 * @param n 
	 */
	function loadSystemSound(n : number): void;
		
	/**
	 * 
	 * @param n 
	 */
	function playSystemSound(n : number): void;
		
	/**
	 * 
	 */
	function playCursor(): void;
		
	/**
	 * 
	 */
	function playOk(): void;
		
	/**
	 * 
	 */
	function playCancel(): void;
		
	/**
	 * 
	 */
	function playBuzzer(): void;
		
	/**
	 * 
	 */
	function playEquip(): void;
		
	/**
	 * 
	 */
	function playSave(): void;
		
	/**
	 * 
	 */
	function playLoad(): void;
		
	/**
	 * 
	 */
	function playBattleStart(): void;
		
	/**
	 * 
	 */
	function playEscape(): void;
		
	/**
	 * 
	 */
	function playEnemyAttack(): void;
		
	/**
	 * 
	 */
	function playEnemyDamage(): void;
		
	/**
	 * 
	 */
	function playEnemyCollapse(): void;
		
	/**
	 * 
	 */
	function playBossCollapse1(): void;
		
	/**
	 * 
	 */
	function playBossCollapse2(): void;
		
	/**
	 * 
	 */
	function playActorDamage(): void;
		
	/**
	 * 
	 */
	function playActorCollapse(): void;
		
	/**
	 * 
	 */
	function playRecovery(): void;
		
	/**
	 * 
	 */
	function playMiss(): void;
		
	/**
	 * 
	 */
	function playEvasion(): void;
		
	/**
	 * 
	 */
	function playMagicEvasion(): void;
		
	/**
	 * 
	 */
	function playReflection(): void;
		
	/**
	 * 
	 */
	function playShop(): void;
		
	/**
	 * 
	 */
	function playUseItem(): void;
		
	/**
	 * 
	 */
	function playUseSkill(): void;
}

/**
 * -----------------------------------------------------------------------------
 * TextManager
 * 
 * The static class that handles terms and messages.
 */
declare interface TextManager {
		
	/**
	 * 
	 * @return  
	 */
	new (): TextManager;
}


/**
 * 
 */
declare namespace TextManager{
		
	/**
	 * 
	 * @param basicId 
	 * @return  
	 */
	function basic(basicId : any): string;
		
	/**
	 * 
	 * @param paramId 
	 * @return  
	 */
	function param(paramId : any): string;
		
	/**
	 * 
	 * @param commandId 
	 * @return  
	 */
	function command(commandId : any): string;
		
	/**
	 * 
	 * @param messageId 
	 * @return  
	 */
	function message(messageId : any): string;
		
	/**
	 * 
	 * @param method 
	 * @param param 
	 * @return  
	 */
	function getter(method : string, param : number | string): TextManager.GetterRet;
}

/**
 * -----------------------------------------------------------------------------
 * SceneManager
 * 
 * The static class that manages scene transitions.
 */
declare interface SceneManager {
		
	/**
	 * 
	 * @return  
	 */
	new (): SceneManager;
}


/**
 * 
 */
declare namespace SceneManager{
		
	/**
	 * Gets the current time in ms without on iOS Safari.
	 * @private
	 */
	function _getTimeInMsWithoutMobileSafari(): void;

    // TODO:_scene’Ç‰Á
    export var _scene: Array<any>;

	/**
	 * 
	 */
	export var _stack : Array<any>;
		
	/**
	 * 
	 */
	export var _stopped : boolean;
		
	/**
	 * 
	 */
	export var _sceneStarted : boolean;
		
	/**
	 * 
	 */
	export var _exiting : boolean;
		
	/**
	 * 
	 */
	export var _screenWidth : number;
		
	/**
	 * 
	 */
	export var _screenHeight : number;
		
	/**
	 * 
	 */
	export var _boxWidth : number;
		
	/**
	 * 
	 */
	export var _boxHeight : number;
		
	/**
	 * 
	 */
	export var _deltaTime : number;
		
	/**
	 * 
	 */
	export var _accumulator : number;
		
	/**
	 * 
	 * @param sceneClass 
	 */
	function run(sceneClass : any): void;
		
	/**
	 * 
	 */
	function initialize(): void;
		
	/**
	 * 
	 */
	function initGraphics(): void;
		
	/**
	 * 
	 * @return  
	 */
	function preferableRendererType(): string;
		
	/**
	 * 
	 */
	function shouldUseCanvasRenderer(): void;
		
	/**
	 * 
	 */
	function checkWebGL(): void;
		
	/**
	 * 
	 */
	function checkFileAccess(): void;
		
	/**
	 * 
	 */
	function initAudio(): void;
		
	/**
	 * 
	 */
	function initInput(): void;
		
	/**
	 * 
	 */
	function initNwjs(): void;
		
	/**
	 * 
	 */
	function checkPluginErrors(): void;
		
	/**
	 * 
	 */
	function setupErrorHandlers(): void;
		
	/**
	 * 
	 */
	function requestUpdate(): void;
		
	/**
	 * 
	 */
	function update(): void;
		
	/**
	 * 
	 */
	function terminate(): void;
		
	/**
	 * 
	 * @param e 
	 */
	function onError(e : any): void;
		
	/**
	 * 
	 * @param event 
	 */
	function onKeyDown(event : any): void;
		
	/**
	 * 
	 * @param e 
	 */
	function catchException(e : any): void;
		
	/**
	 * 
	 */
	function tickStart(): void;
		
	/**
	 * 
	 */
	function tickEnd(): void;
		
	/**
	 * 
	 */
	function updateInputData(): void;
		
	/**
	 * 
	 */
	function updateMain(): void;
		
	/**
	 * 
	 */
	function updateManagers(): void;
		
	/**
	 * 
	 */
	function changeScene(): void;
		
	/**
	 * 
	 */
	function updateScene(): void;
		
	/**
	 * 
	 */
	function renderScene(): void;
		
	/**
	 * 
	 */
	function onSceneCreate(): void;
		
	/**
	 * 
	 */
	function onSceneStart(): void;
		
	/**
	 * 
	 */
	function onSceneLoading(): void;
		
	/**
	 * 
	 * @return  
	 */
	function isSceneChanging(): /* !this._exiting */ any;
		
	/**
	 * 
	 * @return  
	 */
	function isCurrentSceneBusy(): /* !this._scene */ any;
		
	/**
	 * 
	 * @return  
	 */
	function isCurrentSceneStarted(): /* !this._scene */ any;
		
	/**
	 * 
	 * @param sceneClass 
	 * @return  
	 */
	function isNextScene(sceneClass : any): /* !this._nextScene */ any;
		
	/**
	 * 
	 * @param sceneClass 
	 * @return  
	 */
	function isPreviousScene(sceneClass : any): boolean;
		
	/**
	 * 
	 * @param sceneClass 
	 */
	function goto(sceneClass : any): void;
		
	/**
	 * 
	 * @param sceneClass 
	 */
	function push(sceneClass : any): void;
		
	/**
	 * 
	 */
	function pop(): void;
		
	/**
	 * 
	 */
	function exit(): void;
		
	/**
	 * 
	 */
	function clearStack(): void;
		
	/**
	 * 
	 */
	function stop(): void;
		
	/**
	 * 
	 */
	function prepareNextScene(): void;
		
	/**
	 * 
	 */
	function snap(): void;
		
	/**
	 * 
	 */
	function snapForBackground(): void;
		
	/**
	 * 
	 * @return  
	 */
	function backgroundBitmap(): /* !this._backgroundBitmap */ any;
		
	/**
	 * 
	 */
	function resume(): void;
}

/**
 * -----------------------------------------------------------------------------
 * BattleManager
 * 
 * The static class that manages battle progress.
 */
declare interface BattleManager {
		
	/**
	 * 
	 * @return  
	 */
	new (): BattleManager;
}


/**
 * 
 */
declare namespace BattleManager{
		
	/**
	 * 
	 * @param troopId 
	 * @param canEscape 
	 * @param canLose 
	 */
	function setup(troopId : any, canEscape : boolean, canLose : boolean): void;
		
	/**
	 * 
	 */
	export var _canEscape : boolean;
		
	/**
	 * 
	 */
	export var _canLose : boolean;
		
	/**
	 * 
	 */
	function initMembers(): void;
		
	/**
	 * 
	 */
	export var _phase : string;
		
	/**
	 * 
	 */
	export var _battleTest : boolean;
		
	/**
	 * 
	 */
	export var _preemptive : boolean;
		
	/**
	 * 
	 */
	export var _surprise : boolean;
		
	/**
	 * 
	 */
	export var _actorIndex : number;
	
	/**
	 * 
	 */
	var _mapBgm : {
				
		/**
		 * 
		 */
		pos : number;
	}
	
	/**
	 * 
	 */
	var _mapBgs : {
				
		/**
		 * 
		 */
		pos : number;
	}
		
	/**
	 * 
	 */
	export var _actionBattlers : Array<any>;
		
	/**
	 * 
	 */
	export var _targets : Array<any>;
		
	/**
	 * 
	 */
	export var _escapeRatio : number;
		
	/**
	 * 
	 */
	export var _escaped : boolean;
		
	/**
	 * 
	 */
	export var _rewards : /*no type*/{};
		
	/**
	 * 
	 */
	export var _turnForced : boolean;
		
	/**
	 * 
	 * @return  
	 */
	function isBattleTest(): /* !this._battleTest */ any;
		
	/**
	 * 
	 * @param battleTest 
	 */
	function setBattleTest(battleTest : boolean): void;
		
	/**
	 * 
	 * @param callback 
	 */
	function setEventCallback(callback : any): void;
		
	/**
	 * 
	 * @param logWindow 
	 */
	function setLogWindow(logWindow : any): void;
		
	/**
	 * 
	 * @param statusWindow 
	 */
	function setStatusWindow(statusWindow : any): void;
		
	/**
	 * 
	 * @param spriteset 
	 */
	function setSpriteset(spriteset : any): void;
		
	/**
	 * 
	 */
	function onEncounter(): void;
		
	/**
	 * 
	 */
	function ratePreemptive(): void;
		
	/**
	 * 
	 */
	function rateSurprise(): void;
		
	/**
	 * 
	 */
	function saveBgmAndBgs(): void;
		
	/**
	 * 
	 */
	function playBattleBgm(): void;
		
	/**
	 * 
	 */
	function playVictoryMe(): void;
		
	/**
	 * 
	 */
	function playDefeatMe(): void;
		
	/**
	 * 
	 */
	function replayBgmAndBgs(): void;
		
	/**
	 * 
	 */
	function makeEscapeRatio(): void;
		
	/**
	 * 
	 */
	function update(): void;
		
	/**
	 * 
	 * @return  
	 */
	function updateEvent(): boolean;
		
	/**
	 * 
	 * @return  
	 */
	function updateEventMain(): boolean;
		
	/**
	 * 
	 */
	function isBusy(): void;
		
	/**
	 * 
	 * @return  
	 */
	function isInputting(): boolean;
		
	/**
	 * 
	 * @return  
	 */
	function isInTurn(): boolean;
		
	/**
	 * 
	 * @return  
	 */
	function isTurnEnd(): boolean;
		
	/**
	 * 
	 * @return  
	 */
	function isAborting(): boolean;
		
	/**
	 * 
	 * @return  
	 */
	function isBattleEnd(): boolean;
		
	/**
	 * 
	 * @return  
	 */
	function canEscape(): /* !this._canEscape */ any;
		
	/**
	 * 
	 * @return  
	 */
	function canLose(): /* !this._canLose */ any;
		
	/**
	 * 
	 * @return  
	 */
	function isEscaped(): /* !this._escaped */ any;
		
	/**
	 * 
	 */
	function actor(): void;
		
	/**
	 * 
	 */
	function clearActor(): void;
		
	/**
	 * 
	 * @param newActorIndex 
	 * @param lastActorActionState 
	 */
	function changeActor(newActorIndex : number, lastActorActionState : string): void;
		
	/**
	 * 
	 */
	function startBattle(): void;
		
	/**
	 * 
	 */
	function displayStartMessages(): void;
		
	/**
	 * 
	 */
	function startInput(): void;
		
	/**
	 * 
	 */
	function inputtingAction(): void;
		
	/**
	 * 
	 */
	function selectNextCommand(): void;
		
	/**
	 * 
	 */
	function selectPreviousCommand(): void;
		
	/**
	 * 
	 */
	function refreshStatus(): void;
		
	/**
	 * 
	 */
	function startTurn(): void;
		
	/**
	 * 
	 */
	function updateTurn(): void;
		
	/**
	 * 
	 */
	function processTurn(): void;
		
	/**
	 * 
	 */
	function endTurn(): void;
		
	/**
	 * 
	 * @return  
	 */
	function isForcedTurn(): /* !this._turnForced */ any;
		
	/**
	 * 
	 */
	function updateTurnEnd(): void;
		
	/**
	 * 
	 */
	function getNextSubject(): void;
		
	/**
	 * 
	 */
	function allBattleMembers(): void;
		
	/**
	 * 
	 */
	function makeActionOrders(): void;
		
	/**
	 * 
	 */
	function startAction(): void;
		
	/**
	 * 
	 */
	function updateAction(): void;
		
	/**
	 * 
	 */
	function endAction(): void;
		
	/**
	 * 
	 * @param subject 
	 * @param target 
	 */
	function invokeAction(subject : any, target : any): void;
		
	/**
	 * 
	 * @param subject 
	 * @param target 
	 */
	function invokeNormalAction(subject : any, target : any): void;
		
	/**
	 * 
	 * @param subject 
	 * @param target 
	 */
	function invokeCounterAttack(subject : any, target : any): void;
		
	/**
	 * 
	 * @param subject 
	 * @param target 
	 */
	function invokeMagicReflection(subject : any, target : any): void;
		
	/**
	 * 
	 * @param target 
	 * @return  
	 */
	function applySubstitute(target : any): any;
		
	/**
	 * 
	 * @param target 
	 * @return  
	 */
	function checkSubstitute(target : any): boolean;
		
	/**
	 * 
	 * @return  
	 */
	function isActionForced(): boolean;
		
	/**
	 * 
	 * @param battler 
	 */
	function forceAction(battler : any): void;
		
	/**
	 * 
	 */
	function processForcedAction(): void;
		
	/**
	 * 
	 */
	function abort(): void;
		
	/**
	 * 
	 * @return  
	 */
	function checkBattleEnd(): boolean;
		
	/**
	 * 
	 * @return  
	 */
	function checkAbort(): boolean;
		
	/**
	 * 
	 */
	function processVictory(): void;
		
	/**
	 * 
	 * @return  
	 */
	function processEscape(): boolean;
		
	/**
	 * 
	 */
	function processAbort(): void;
		
	/**
	 * 
	 */
	function processDefeat(): void;
		
	/**
	 * 
	 * @param result 
	 */
	function endBattle(result : number): void;
		
	/**
	 * 
	 */
	function updateBattleEnd(): void;
		
	/**
	 * 
	 */
	function makeRewards(): void;
		
	/**
	 * 
	 */
	function displayVictoryMessage(): void;
		
	/**
	 * 
	 */
	function displayDefeatMessage(): void;
		
	/**
	 * 
	 */
	function displayEscapeSuccessMessage(): void;
		
	/**
	 * 
	 */
	function displayEscapeFailureMessage(): void;
		
	/**
	 * 
	 */
	function displayRewards(): void;
		
	/**
	 * 
	 */
	function displayExp(): void;
		
	/**
	 * 
	 */
	function displayGold(): void;
		
	/**
	 * 
	 */
	function displayDropItems(): void;
		
	/**
	 * 
	 */
	function gainRewards(): void;
		
	/**
	 * 
	 */
	function gainExp(): void;
		
	/**
	 * 
	 */
	function gainGold(): void;
		
	/**
	 * 
	 */
	function gainDropItems(): void;
}

/**
 * -----------------------------------------------------------------------------
 * PluginManager
 * 
 * The static class that manages the plugins.
 */
declare interface PluginManager {
		
	/**
	 * 
	 * @return  
	 */
	new (): PluginManager;
}


/**
 * 
 */
declare namespace PluginManager{
		
	/**
	 * 
	 */
	export var _path : string;
		
	/**
	 * 
	 */
	export var _scripts : Array<any>;
		
	/**
	 * 
	 */
	export var _errorUrls : Array<any>;
		
	/**
	 * 
	 */
	export var _parameters : /*no type*/{};
		
	/**
	 * 
	 * @param plugins 
	 */
	function setup(plugins : any): void;
		
	/**
	 * 
	 */
	function checkErrors(): void;
		
	/**
	 * 
	 * @param name 
	 * @return  
	 */
	function parameters(name : any): /* !this._parameters.<i> */ any;
		
	/**
	 * 
	 * @param name 
	 * @param parameters 
	 */
	function setParameters(name : any, parameters : any): void;
		
	/**
	 * 
	 * @param name 
	 */
	function loadScript(name : any): void;
		
	/**
	 * 
	 * @param e 
	 */
	function onError(e : any): void;
}

declare var $dataActors: IDataActor[];
declare var $dataClasses: IDataClass[];
declare var $dataSkills: IDataSkill[];
declare var $dataItems: IDataItem[];
declare var $dataWeapons: IDataWeapon[];
declare var $dataArmors: IDataArmor[];
declare var $dataEnemies: IDataEnemy[];
declare var $dataTroops: IDataTroop[];
declare var $dataStates: IDataState[];
declare var $dataAnimations: IDataAnimation[];
declare var $dataTilesets: IDataTileset[];
declare var $dataCommonEvents: IDataCommonEvent[];
declare var $dataSystem: IDataSystem;
declare var $dataMapInfos: IDataMapInfo[];

declare var $dataMap: IDataMap;

declare var $gameTemp: Game_Temp;
declare var $gameSystem: Game_System;
declare var $gameScreen: Game_Screen;
declare var $gameTimer: Game_Timer;
declare var $gameMessage: Game_Message;
declare var $gameSwitches: Game_Switches;
declare var $gameVariables: Game_Variables;
declare var $gameSelfSwitches: Game_SelfSwitches;
declare var $gameMap: Game_Map;
declare var $gameActors: Game_Actors;
declare var $gameParty: Game_Party;
declare var $gameTroop: Game_Troop;
declare var $gamePlayer: Game_Player;
declare var $testEvent: any; // TODO
