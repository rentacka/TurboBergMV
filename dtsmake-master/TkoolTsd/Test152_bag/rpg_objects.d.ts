// Type definitions for rpg_objects.js
// Project: [LIBRARY_URL_HERE] 
// Definitions by: [YOUR_NAME_HERE] <[YOUR_URL_HERE]> 
// Definitions: https://github.com/borisyankov/DefinitelyTyped
// ver1.5.2

declare namespace Game_Message.prototype{
    // Game_Message.prototype.choices.!ret
    type ChoicesRet = Array<string>;
}

declare namespace Game_Screen.prototype{
	// Game_Screen.prototype.tone.!ret
	type ToneRet = Array<number>;
}

declare namespace Game_Screen.prototype{
	// Game_Screen.prototype.flashColor.!ret
	type FlashColorRet = Array<number>;
}
declare namespace Game_Screen.prototype{
	// Game_Screen.prototype.startFlash.!0
	type StartFlash0 = Array<number>;
}

// #region Game_Action
declare namespace Game_Action.prototype{
	// Game_Action.prototype.checkItemScope.!0
	type CheckItemScope0 = Array<number>;
}
declare namespace Game_Action.prototype{
	// Game_Action.prototype.checkDamageType.!0
	type CheckDamageType0 = Array<number>;
}

declare namespace Game_Action.prototype{
	// Game_Action.prototype.makeTargets.!ret
    type MakeTargetsRet = Array<Game_Battler>;
}
declare namespace Game_Action.prototype{
	// Game_Action.prototype.repeatTargets.!0
    type RepeatTargets0 = Array<Game_Battler>;
}
declare namespace Game_Action.prototype{
	// Game_Action.prototype.repeatTargets.!ret
    type RepeatTargetsRet = Array<Game_Battler>;
}
declare namespace Game_Action.prototype{
	// Game_Action.prototype.targetsForOpponents.!ret
    type TargetsForOpponentsRet = Array<Game_Battler>;
}
declare namespace Game_Action.prototype{
	// Game_Action.prototype.targetsForFriends.!ret
    type TargetsForFriendsRet = Array<Game_Battler>;
}
declare namespace Game_Action.prototype{
	// Game_Action.prototype.itemTargetCandidates.!ret
    type ItemTargetCandidatesRet = Array<Game_Battler>;
}
declare namespace Game_ActionResult.prototype{
	// Game_ActionResult.prototype.addedStateObjects.!ret
    type AddedStateObjectsRet = Array<IDataState>;
}
declare namespace Game_ActionResult.prototype{
	// Game_ActionResult.prototype.removedStateObjects.!ret
    type RemovedStateObjectsRet = Array<IDataState>;
}
// #endregion

// #region Game_BattlerBase
declare namespace Game_BattlerBase.prototype{
	// Game_BattlerBase.prototype.states.!ret
    type StatesRet = Array<IDataState>;
}
declare namespace Game_BattlerBase.prototype{
    // Game_BattlerBase.prototype.stateIcons.!ret
    type StateIconsRet = Array<number>;
}
declare namespace Game_BattlerBase.prototype{
	// Game_BattlerBase.prototype.buffIcons.!ret
	type BuffIconsRet = Array<number>;
}
declare namespace Game_BattlerBase.prototype{
	// Game_BattlerBase.prototype.allTraits.!ret
    type AllTraitsRet = Array</* Game_BattlerBase.prototype.allTraits.+Game_SelfSwitches */ IDataTrait>;
}
declare namespace Game_BattlerBase.prototype{
	// Game_BattlerBase.prototype.traitsSet.!ret
	type TraitsSetRet = Array<number>;
}
declare namespace Game_BattlerBase.prototype{
    // Game_BattlerBase.prototype.actionPlusSet.!ret
    type ActionPlusSetRet = Array<number>;
}
// #endregion

declare namespace Game_Battler.prototype{
	// Game_Battler.prototype.shiftAnimation.!ret
	
	/**
	 * 
	 */
	interface ShiftAnimationRet {
				
		/**
		 * 
		 */
		mirror : boolean;
	}
}

// #region Game_Actor
declare namespace Game_Actor.prototype{
	// Game_Actor.prototype.equipSlots.!ret
	type EquipSlotsRet = Array<number>;
}
declare namespace Game_Actor.prototype{
	// Game_Actor.prototype.equips.!ret
    type EquipsRet = Array<number>;
}
declare namespace Game_Actor.prototype{
    // Game_Actor.prototype.skills.!ret
    type SkillsRet = Array<IDataSkill>;
}
declare namespace Game_Actor.prototype{
    // Game_Actor.prototype.makeActionList.!ret
    type MakeActionListRet = Array<Game_Action>;
}
// #endregion

// #region Game_Unit
declare namespace Game_Unit.prototype{
	//TODO: Game_Unit.prototype.members.!ret Œ^
    type MembersRet = Array<Game_Battler>;
}
declare namespace Game_Unit.prototype{
	// Game_Unit.prototype.aliveMembers.!ret
    type AliveMembersRet = Array<Game_Battler>;
}
declare namespace Game_Unit.prototype{
	// Game_Unit.prototype.deadMembers.!ret
    type DeadMembersRet = Array<Game_Battler>;
}
// #endregion

// #region Game_Party
declare namespace Game_Party.prototype{
	// Game_Party.prototype.items.!ret
    type ItemsRet = Array<IDataItem>;
}
declare namespace Game_Party.prototype{
    // Game_Party.prototype.weapons.!ret
    type WeaponsRet = Array<IDataWeapon>;
}
declare namespace Game_Party.prototype{
    // Game_Party.prototype.armors.!ret
    type ArmorsRet = Array<IDataArmor>;
}
declare namespace Game_Party.prototype{
	// Game_Party.prototype.charactersForSavefile.!ret
	type CharactersForSavefileRet = Array<Game_Party.prototype.charactersForSavefile.CharactersForSavefileRetI>;
}
declare namespace Game_Party.prototype.charactersForSavefile{
	// Game_Party.prototype.charactersForSavefile.!ret.<i>
    //type CharactersForSavefileRetI = Array</* ?,? */ any>;
    type CharactersForSavefileRetI =  [string, number]
}
declare namespace Game_Party.prototype{
	// Game_Party.prototype.facesForSavefile.!ret
	type FacesForSavefileRet = Array<Game_Party.prototype.facesForSavefile.FacesForSavefileRetI>;
}
declare namespace Game_Party.prototype.facesForSavefile{
    // Game_Party.prototype.facesForSavefile.!ret.<i>
    //type FacesForSavefileRetI = Tuple<string, number>[];
    type FacesForSavefileRetI = [string, number]
}
// #endregion

declare namespace Game_Troop.prototype{
	// Game_Troop.prototype.enemyNames.!ret
    type EnemyNamesRet = Array<string>;
}
declare namespace Game_Troop.prototype{
	// Game_Troop.prototype.makeDropItems.!ret
    type MakeDropItemsRet = Array<IDataItem>;
}

// #region Game_Map
declare namespace Game_Map.prototype{
	// Game_Map.prototype.vehicles.!ret
	type VehiclesRet = Array<Game_Vehicle>;
}
declare namespace Game_Map.prototype{
	// Game_Map.prototype.events.!ret
	type EventsRet = Array<Game_Event>;
}
declare namespace Game_Map.prototype{
    // Game_Map.prototype.tilesetFlags.!ret
    type TilesetFlagsRet = Array<number>;
}
declare namespace Game_Map.prototype{
	// Game_Map.prototype.canvasToMapX.!0
	type CanvasToMapX0 = number;
}
declare namespace Game_Map.prototype{
	// Game_Map.prototype.canvasToMapY.!0
	type CanvasToMapY0 = number;
}
declare namespace Game_Map.prototype{
	// Game_Map.prototype.layeredTiles.!ret
	type LayeredTilesRet = Array<number>;
}
declare namespace Game_Map.prototype{
	// Game_Map.prototype.allTiles.!ret
	type AllTilesRet = Array<number>;
}
// #endregion

declare namespace Game_Character.prototype{
	// Game_Character.prototype.moveTowardCharacter.!0
	
	/**
	 * 
	 */
	interface MoveTowardCharacter0 {
				
		/**
		 * 
		 */
		g : number;
				
		/**
		 * 
		 */
		parent : /* Game_Character.prototype.moveTowardCharacter.!0 */ any;
	}
}

// #region Game_Player
declare namespace Game_Player.prototype{
	// Game_Player.prototype.startMapEvent.!2
	type StartMapEvent2 = Array<number>;
}
declare namespace Game_Player.prototype{
	// Game_Player.prototype.checkEventTriggerHere.!0
	type CheckEventTriggerHere0 = Array<number>;
}
declare namespace Game_Player.prototype{
	// Game_Player.prototype.checkEventTriggerThere.!0
	type CheckEventTriggerThere0 = Array<number>;
}
// #endregion

declare namespace Game_Followers.prototype{
	// Game_Followers.prototype.forEach.!0
	type ForEach0 = ((follower : Game_Follower) => void);
}
declare namespace Game_Event.prototype{
	// Game_Event.prototype.isTriggerIn.!0
	type IsTriggerIn0 = Array<number>;
}
declare namespace Game_Interpreter.prototype{
	// Game_Interpreter.prototype.iterateActorId.!1
	type IterateActorId1 = ((battler : any) => void);
}
declare namespace Game_Interpreter.prototype{
	// Game_Interpreter.prototype.iterateActorEx.!2
	type IterateActorEx2 = ((actor : any) => void);
}
declare namespace Game_Interpreter{
	// Game_Interpreter.requestImages.!1
	type RequestImages1 = Array<any>;
}
declare namespace Game_Actor{
	// Game_Actor._animations.<i>

	/**
	 * 
	 */
    interface _animationsI {
        mirror: boolean;
	}
}
declare namespace Game_Followers.prototype{
	// Game_Followers.prototype.visibleFollowers.!ret
	
	/**
	 * 
	 */
	interface VisibleFollowersRet {
	}
}

/**
 * -----------------------------------------------------------------------------
 * Game_Temp
 * 
 * The game object class for temporary data that is not included in save data.
 */
declare interface Game_Temp {
		
	/**
	 * 
	 */
	new ();
		
	/**
	 * 
	 */
	initialize(): void;
		
	/**
	 * 
	 * @return  
	 */
    isPlaytest(): /* !this._isPlaytest */ boolean;
		
	/**
	 * 
	 * @param commonEventId 
	 */
	reserveCommonEvent(commonEventId : number): void;
		
	/**
	 * 
	 */
	clearCommonEvent(): void;
		
	/**
	 * 
	 * @return  
	 */
	isCommonEventReserved(): boolean;
		
	/**
	 * 
	 */
	reservedCommonEvent(): void;
		
	/**
	 * 
	 * @param x 
	 * @param y 
	 */
    setDestination(x: number, y: number): void;
		
	/**
	 * 
	 */
	clearDestination(): void;
		
	/**
	 * 
	 * @return  
	 */
	isDestinationValid(): boolean;
		
	/**
	 * 
	 * @return  
	 */
    destinationX(): /* !this._destinationX */ number;
		
	/**
	 * 
	 * @return  
	 */
    destinationY(): /* !this._destinationY */ number;
}

/**
 * -----------------------------------------------------------------------------
 * Game_System
 * 
 * The game object class for the system data.
 */
declare interface Game_System {
		
	/**
	 * 
	 */
	new ();
		
	/**
	 * 
	 */
	initialize(): void;
		
	/**
	 * 
	 */
    isJapanese(): boolean;
		
	/**
	 * 
	 */
    isChinese(): boolean;
		
	/**
	 * 
	 */
    isKorean(): boolean;
		
	/**
	 * 
	 */
    isCJK(): boolean;
		
	/**
	 * 
	 */
    isRussian(): boolean;
		
	/**
	 * 
	 */
    isSideView(): boolean;
		
	/**
	 * 
	 * @return  
	 */
    isSaveEnabled(): /* !this._saveEnabled */ boolean;
		
	/**
	 * 
	 */
	disableSave(): void;
		
	/**
	 * 
	 */
	enableSave(): void;
		
	/**
	 * 
	 * @return  
	 */
    isMenuEnabled(): /* !this._menuEnabled */ boolean;
		
	/**
	 * 
	 */
	disableMenu(): void;
		
	/**
	 * 
	 */
	enableMenu(): void;
		
	/**
	 * 
	 * @return  
	 */
    isEncounterEnabled(): /* !this._encounterEnabled */ boolean;
		
	/**
	 * 
	 */
	disableEncounter(): void;
		
	/**
	 * 
	 */
	enableEncounter(): void;
		
	/**
	 * 
	 * @return  
	 */
    isFormationEnabled(): /* !this._formationEnabled */ boolean;
		
	/**
	 * 
	 */
	disableFormation(): void;
		
	/**
	 * 
	 */
	enableFormation(): void;
		
	/**
	 * 
	 * @return  
	 */
    battleCount(): /* !this._battleCount */ number;
		
	/**
	 * 
	 * @return  
	 */
    winCount(): /* !this._winCount */ number;
		
	/**
	 * 
	 * @return  
	 */
    escapeCount(): /* !this._escapeCount */ number;
		
	/**
	 * 
	 * @return  
	 */
	saveCount(): /* !this._saveCount */ any;
		
	/**
	 * 
	 * @return  
	 */
    versionId(): /* !this._versionId */ number;
		
	/**
	 * 
	 * @return  
	 */
    windowTone(): /* !this._windowTone */ Array<number>;
		
	/**
	 * 
	 * @param value 
	 */
    setWindowTone(value: number[]): void;
		
	/**
	 * 
	 * @return  
	 */
    battleBgm(): /* !this._battleBgm */ IDataSound;
		
	/**
	 * 
	 * @param value 
	 */
    setBattleBgm(value: IDataSound): void;
		
	/**
	 * 
	 * @return  
	 */
    victoryMe(): /* !this._victoryMe */ IDataSound;
		
	/**
	 * 
	 * @param value 
	 */
    setVictoryMe(value: IDataSound): void;
		
	/**
	 * 
	 * @return  
	 */
    defeatMe(): /* !this._defeatMe */ IDataSound;
		
	/**
	 * 
	 * @param value 
	 */
    setDefeatMe(value: IDataSound): void;
		
	/**
	 * 
	 */
	onBattleStart(): void;
		
	/**
	 * 
	 */
	onBattleWin(): void;
		
	/**
	 * 
	 */
	onBattleEscape(): void;
		
	/**
	 * 
	 */
	onBeforeSave(): void;
		
	/**
	 * 
	 */
	onAfterLoad(): void;
		
	/**
	 * 
	 * @return  
	 */
	playtime(): number;
		
	/**
	 * 
	 * @return  
	 */
	playtimeText(): string;
		
	/**
	 * 
	 */
	saveBgm(): void;
		
	/**
	 * 
	 */
	replayBgm(): void;
		
	/**
	 * 
	 */
	saveWalkingBgm(): void;
		
	/**
	 * 
	 */
	replayWalkingBgm(): void;
		
	/**
	 * 
	 */
	saveWalkingBgm2(): void;
}

/**
 * -----------------------------------------------------------------------------
 * Game_Timer
 * 
 * The game object class for the timer.
 */
declare interface Game_Timer {
		
	/**
	 * 
	 */
	new ();
		
	/**
	 * 
	 */
	initialize(): void;
		
	/**
	 * 
	 * @param sceneActive 
	 */
    update(sceneActive: boolean): void;
		
	/**
	 * 
	 * @param count 
	 */
    start(count: number): void;
		
	/**
	 * 
	 */
	stop(): void;
		
	/**
	 * 
	 * @return  
	 */
    isWorking(): /* !this._working */ boolean;
		
	/**
	 * 
	 * @return  
	 */
	seconds(): number;
		
	/**
	 * 
	 */
	onExpire(): void;
}

/**
 * -----------------------------------------------------------------------------
 * Game_Message
 * 
 * The game object class for the state of the message window that displays text
 * or selections, etc.
 */
declare interface Game_Message {
		
	/**
	 * 
	 */
	new ();
		
	/**
	 * 
	 */
	initialize(): void;
		
	/**
	 * 
	 */
	clear(): void;
		
	/**
	 * 
	 * @return  
	 */
	choices(): Game_Message.prototype.ChoicesRet;
		
	/**
	 * 
	 * @return  
	 */
    faceName(): /* !this._faceName */ string;
		
	/**
	 * 
	 * @return  
	 */
    faceIndex(): /* !this._faceIndex */ number;
		
	/**
	 * 
	 * @return  
	 */
	background(): /* !this._background */ number;
		
	/**
	 * 
	 * @return  
	 */
    positionType(): /* !this._positionType */ number;
		
	/**
	 * 
	 * @return  
	 */
    choiceDefaultType(): /* !this._choiceDefaultType */ number;
		
	/**
	 * 
	 * @return  
	 */
    choiceCancelType(): /* !this._choiceCancelType */ number;
		
	/**
	 * 
	 * @return  
	 */
    choiceBackground(): /* !this._choiceBackground */ number;
		
	/**
	 * 
	 * @return  
	 */
    choicePositionType(): /* !this._choicePositionType */ number;
		
	/**
	 * 
	 * @return  
	 */
    numInputVariableId(): /* !this._numInputVariableId */ number;
		
	/**
	 * 
	 * @return  
	 */
    numInputMaxDigits(): /* !this._numInputMaxDigits */ number;
		
	/**
	 * 
	 * @return  
	 */
    itemChoiceVariableId(): /* !this._itemChoiceVariableId */ number;
		
	/**
	 * 
	 * @return  
	 */
    itemChoiceItypeId(): /* !this._itemChoiceItypeId */ number;
		
	/**
	 * 
	 * @return  
	 */
    scrollMode(): /* !this._scrollMode */ boolean;
		
	/**
	 * 
	 * @return  
	 */
    scrollSpeed(): /* !this._scrollSpeed */ number;
		
	/**
	 * 
	 * @return  
	 */
    scrollNoFast(): /* !this._scrollNoFast */ boolean;
		
	/**
	 * 
	 * @param text 
	 */
    add(text: string): void;
		
	/**
	 * 
	 * @param faceName 
	 * @param faceIndex 
	 */
    setFaceImage(faceName: string, faceIndex: number): void;
		
	/**
	 * 
	 * @param background 
	 */
    setBackground(background: number): void;
		
	/**
	 * 
	 * @param positionType 
	 */
    setPositionType(positionType: number): void;
		
	/**
	 * 
	 * @param choices 
	 * @param defaultType 
	 * @param cancelType 
	 */
    setChoices(choices: string[], defaultType: number, cancelType: number): void;
		
	/**
	 * 
	 * @param background 
	 */
    setChoiceBackground(background: number): void;
		
	/**
	 * 
	 * @param positionType 
	 */
    setChoicePositionType(positionType: number): void;
		
	/**
	 * 
	 * @param variableId 
	 * @param maxDigits 
	 */
    setNumberInput(variableId: number, maxDigits: number): void;
		
	/**
	 * 
	 * @param variableId 
	 * @param itemType 
	 */
    setItemChoice(variableId: number, itemType: number): void;
		
	/**
	 * 
	 * @param speed 
	 * @param noFast 
	 */
    setScroll(speed: number, noFast: boolean): void;
		
	/**
	 * 
	 * @param callback 
	 */
    setChoiceCallback(callback: Function): void;
		
	/**
	 * 
	 * @param n 
	 */
    onChoice(n: number): void;
		
	/**
	 * 
	 * @return  
	 */
	hasText(): boolean;
		
	/**
	 * 
	 * @return  
	 */
	isChoice(): boolean;
		
	/**
	 * 
	 * @return  
	 */
	isNumberInput(): boolean;
		
	/**
	 * 
	 * @return  
	 */
	isItemChoice(): boolean;
		
	/**
	 * 
	 * @return  
	 */
	isBusy(): boolean;
		
	/**
	 * 
	 */
	newPage(): void;
		
	/**
	 * 
	 * @return  
	 */
	allText(): string;
}

/**
 * -----------------------------------------------------------------------------
 * Game_Switches
 * 
 * The game object class for switches.
 */
declare interface Game_Switches {
		
	/**
	 * 
	 */
	new ();
		
	/**
	 * 
	 */
	initialize(): void;
		
	/**
	 * 
	 */
	clear(): void;
		
	/**
	 * 
	 * @param switchId 
	 * @return  
	 */
    value(switchId: number): boolean;
		
	/**
	 * 
	 * @param switchId 
	 * @param value 
	 */
    setValue(switchId: number, value: boolean): void;
		
	/**
	 * 
	 */
	onChange(): void;
}

/**
 * -----------------------------------------------------------------------------
 * Game_Variables
 * 
 * The game object class for variables.
 */
declare interface Game_Variables {
		
	/**
	 * 
	 */
	new ();
		
	/**
	 * 
	 */
	initialize(): void;
		
	/**
	 * 
	 */
	clear(): void;
		
	/**
	 * 
	 * @param variableId 
	 * @return  
	 */
    value(variableId: number): /* !this._data.<i> */ boolean;
		
	/**
	 * 
	 * @param variableId 
	 * @param value 
	 */
    setValue(variableId: number, value: number): void;
		
	/**
	 * 
	 */
	onChange(): void;
}

/**
 * -----------------------------------------------------------------------------
 * Game_SelfSwitches
 * 
 * The game object class for self switches.
 */
declare interface Game_SelfSwitches {
		
	/**
	 * 
	 */
	new ();
		
	/**
	 * 
	 */
	initialize(): void;
		
	/**
	 * 
	 */
	clear(): void;
		
	/**
	 * 
	 * @param key 
	 * @return  
	 */
	value(key : number): boolean;
		
	/**
	 * 
	 * @param key 
	 * @param value 
	 */
    setValue(key: (number | string)[], value: boolean): void;
		
	/**
	 * 
	 */
	onChange(): void;
	
	/**
	 * 
	 */
    _data: {
        [key: string]: boolean
	}
}

/**
 * -----------------------------------------------------------------------------
 * Game_Screen
 * 
 * The game object class for screen effect data, such as changes in color tone
 * and flashes.
 */
declare interface Game_Screen {
		
	/**
	 * 
	 */
	new ();
		
	/**
	 * 
	 */
	initialize(): void;
		
	/**
	 * 
	 */
	clear(): void;
		
	/**
	 * 
	 */
	onBattleStart(): void;
		
	/**
	 * 
	 * @return  
	 */
	brightness(): /* !this._brightness */ number;
		
	/**
	 * 
	 * @return  
	 */
	tone(): Game_Screen.prototype.ToneRet;
		
	/**
	 * 
	 * @return  
	 */
	flashColor(): Game_Screen.prototype.FlashColorRet;
		
	/**
	 * 
	 * @return  
	 */
    shake(): /* !this._shake */ number;
		
	/**
	 * 
	 * @return  
	 */
    zoomX(): /* !this._zoomX */ number;
		
	/**
	 * 
	 * @return  
	 */
    zoomY(): /* !this._zoomY */ number;
		
	/**
	 * 
	 * @return  
	 */
    zoomScale(): /* !this._zoomScale */ number;
		
	/**
	 * 
	 * @return  
	 */
    weatherType(): /* !this._weatherType */ string;
		
	/**
	 * 
	 * @return  
	 */
    weatherPower(): /* !this._weatherPower */ number;
		
	/**
	 * 
	 * @param pictureId 
	 * @return  
	 */
    picture(pictureId: number): /* Game_Screen.prototype.+Game_Picture */ Game_Picture;
		
	/**
	 * 
	 * @param pictureId 
	 * @return  
	 */
    realPictureId(pictureId: number): number;
		
	/**
	 * 
	 */
	clearFade(): void;
		
	/**
	 * 
	 */
	clearTone(): void;
		
	/**
	 * 
	 */
	clearFlash(): void;
		
	/**
	 * 
	 */
	clearShake(): void;
		
	/**
	 * 
	 */
	clearZoom(): void;
		
	/**
	 * 
	 */
	clearWeather(): void;
		
	/**
	 * 
	 */
	clearPictures(): void;
		
	/**
	 * 
	 */
	eraseBattlePictures(): void;
		
	/**
	 * 
	 * @return  
	 */
	maxPictures(): number;
		
	/**
	 * 
	 * @param duration 
	 */
    startFadeOut(duration: number): void;
		
	/**
	 * 
	 * @param duration 
	 */
    startFadeIn(duration: number): void;
		
	/**
	 * 
	 * @param tone 
	 * @param duration 
	 */
    startTint(tone: number[], duration: number): void;
		
	/**
	 * 
	 * @param color 
	 * @param duration 
	 */
	startFlash(color : Game_Screen.prototype.StartFlash0, duration : number): void;
		
	/**
	 * 
	 * @param power 
	 * @param speed 
	 * @param duration 
	 */
    startShake(power: number, speed: number, duration: number): void;
		
	/**
	 * 
	 * @param x 
	 * @param y 
	 * @param scale 
	 * @param duration 
	 */
    startZoom(x: number, y: number, scale: number, duration: number): void;
		
	/**
	 * 
	 * @param x 
	 * @param y 
	 * @param scale 
	 */
    setZoom(x: number, y: number, scale: number): void;
		
	/**
	 * 
	 * @param type 
	 * @param power 
	 * @param duration 
	 */
    changeWeather(type: string, power: number, duration: number): void;
		
	/**
	 * 
	 */
	update(): void;
		
	/**
	 * 
	 */
	updateFadeOut(): void;
		
	/**
	 * 
	 */
	updateFadeIn(): void;
		
	/**
	 * 
	 */
	updateTone(): void;
		
	/**
	 * 
	 */
	updateFlash(): void;
		
	/**
	 * 
	 */
	updateShake(): void;
		
	/**
	 * 
	 */
	updateZoom(): void;
		
	/**
	 * 
	 */
	updateWeather(): void;
		
	/**
	 * 
	 */
	updatePictures(): void;
		
	/**
	 * 
	 */
	startFlashForDamage(): void;
		
	/**
	 * 
	 * @param pictureId 
	 * @param name 
	 * @param origin 
	 * @param x 
	 * @param y 
	 * @param scaleX 
	 * @param scaleY 
	 * @param opacity 
	 * @param blendMode 
	 */
    showPicture(pictureId: number, name: string, origin: number, x: number, y: number, scaleX: number, scaleY: number, opacity: number, blendMode: number): void;
		
	/**
	 * 
	 * @param pictureId 
	 * @param origin 
	 * @param x 
	 * @param y 
	 * @param scaleX 
	 * @param scaleY 
	 * @param opacity 
	 * @param blendMode 
	 * @param duration 
	 */
    movePicture(pictureId: number, origin: number, x: number, y: number, scaleX: number, scaleY: number, opacity: number, blendMode: number, duration: number): void;
		
	/**
	 * 
	 * @param pictureId 
	 * @param speed 
	 */
    rotatePicture(pictureId: number, speed: number): void;
		
	/**
	 * 
	 * @param pictureId 
	 * @param tone 
	 * @param duration 
	 */
    tintPicture(pictureId: number, tone: number[], duration: number): void;
		
	/**
	 * 
	 * @param pictureId 
	 */
    erasePicture(pictureId: number): void;
}

/**
 * -----------------------------------------------------------------------------
 * Game_Picture
 * 
 * The game object class for a picture.
 */
declare interface Game_Picture {
		
	/**
	 * 
	 */
	new ();
		
	/**
	 * 
	 */
	initialize(): void;
		
	/**
	 * 
	 * @return  
	 */
    name(): /* !this._name */ string;
		
	/**
	 * 
	 * @return  
	 */
    origin(): /* !this._origin */ number;
		
	/**
	 * 
	 * @return  
	 */
    x(): /* !this._x */ number;
		
	/**
	 * 
	 * @return  
	 */
    y(): /* !this._y */ number;
		
	/**
	 * 
	 * @return  
	 */
    scaleX(): /* !this._scaleX */ number;
		
	/**
	 * 
	 * @return  
	 */
    scaleY(): /* !this._scaleY */ number;
		
	/**
	 * 
	 * @return  
	 */
    opacity(): /* !this._opacity */ number;
		
	/**
	 * 
	 * @return  
	 */
    blendMode(): /* !this._blendMode */ number;
		
	/**
	 * 
	 * @return  
	 */
    tone(): /* !this._tone */ number[];
		
	/**
	 * 
	 * @return  
	 */
    angle(): /* !this._angle */ number;
		
	/**
	 * 
	 */
	initBasic(): void;
		
	/**
	 * 
	 */
	initTarget(): void;
		
	/**
	 * 
	 */
	initTone(): void;
		
	/**
	 * 
	 */
	initRotation(): void;
		
	/**
	 * 
	 * @param name 
	 * @param origin 
	 * @param x 
	 * @param y 
	 * @param scaleX 
	 * @param scaleY 
	 * @param opacity 
	 * @param blendMode 
	 */
    show(name: string, origin: number, x: number, y: number, scaleX: number, scaleY: number, opacity: number, blendMode: number): void;
		
	/**
	 * 
	 * @param origin 
	 * @param x 
	 * @param y 
	 * @param scaleX 
	 * @param scaleY 
	 * @param opacity 
	 * @param blendMode 
	 * @param duration 
	 */
    move(origin: number, x: number, y: number, scaleX: number, scaleY: number, opacity: number, blendMode: number, duration: number): void;
		
	/**
	 * 
	 * @param speed 
	 */
    rotate(speed: number): void;
		
	/**
	 * 
	 * @param tone 
	 * @param duration 
	 */
    tint(tone: number[], duration: number): void;
		
	/**
	 * 
	 */
	erase(): void;
		
	/**
	 * 
	 */
	update(): void;
		
	/**
	 * 
	 */
	updateMove(): void;
		
	/**
	 * 
	 */
	updateTone(): void;
		
	/**
	 * 
	 */
	updateRotation(): void;
		
	/**
	 * 
	 */
	_name : string;
		
	/**
	 * 
	 */
	_origin : number;
		
	/**
	 * 
	 */
	_x : number;
		
	/**
	 * 
	 */
	_y : number;
		
	/**
	 * 
	 */
	_scaleX : number;
		
	/**
	 * 
	 */
	_scaleY : number;
		
	/**
	 * 
	 */
	_opacity : number;
		
	/**
	 * 
	 */
	_blendMode : number;
		
	/**
	 * 
	 */
	_targetX : number;
		
	/**
	 * 
	 */
	_targetY : number;
		
	/**
	 * 
	 */
	_targetScaleX : number;
		
	/**
	 * 
	 */
	_targetScaleY : number;
		
	/**
	 * 
	 */
	_targetOpacity : number;
		
	/**
	 * 
	 */
	_duration : number;
		
	/**
	 * 
	 */
	_tone : Array<number>;
		
	/**
	 * 
	 */
	_toneDuration : number;
		
	/**
	 * 
	 */
	_angle : number;
		
	/**
	 * 
	 */
	_rotationSpeed : number;
}

/**
 * -----------------------------------------------------------------------------
 * Game_Item
 * 
 * The game object class for handling skills, items, weapons, and armor. It is
 * required because save data should not include the database object itself.
 */
declare interface Game_Item {
		
	/**
	 * 
	 */
	new ();
		
	/**
	 * 
	 * @param item 
	 */
    initialize(item: IDataItem): void;
		
	/**
	 * 
	 * @return  
	 */
	isSkill(): boolean;
		
	/**
	 * 
	 * @return  
	 */
	isItem(): boolean;
		
	/**
	 * 
	 * @return  
	 */
	isUsableItem(): boolean;
		
	/**
	 * 
	 * @return  
	 */
	isWeapon(): boolean;
		
	/**
	 * 
	 * @return  
	 */
	isArmor(): boolean;
		
	/**
	 * 
	 * @return  
	 */
	isEquipItem(): boolean;
		
	/**
	 * 
	 * @return  
	 */
	isNull(): boolean;
		
	/**
	 * 
	 * @return  
	 */
    itemId(): /* !this._itemId */ number;
		
	/**
	 * 
	 */
	object(): void;
		
	/**
	 * 
	 * @param item 
	 */
    setObject(item: IDataItem): void;
		
	/**
	 * 
	 * @param isWeapon 
	 * @param itemId 
	 */
    setEquip(isWeapon: boolean, itemId: number): void;
		
	/**
	 * 
	 */
	_dataClass : string;
		
	/**
	 * 
	 */
	_itemId : number;
}

/**
 * -----------------------------------------------------------------------------
 * Game_Action
 * 
 * The game object class for a battle action.
 */
declare interface Game_Action {
		
	/**
	 * 
	 */
	new ();
		
	/**
	 * 
	 * @param subject 
	 * @param forcing 
	 */
    initialize(subject: Game_Battler | Game_Actor, forcing : boolean): void;
		
	/**
	 * 
	 */
	clear(): void;
		
	/**
	 * 
	 * @param subject 
	 */
    setSubject(subject: Game_Battler): void;
		
	/**
	 * 
	 */
	subject(): void;
		
	/**
	 * 
	 */
	friendsUnit(): void;
		
	/**
	 * 
	 */
	opponentsUnit(): void;
		
	/**
	 * 
	 * @param action 
	 */
    setEnemyAction(action: boolean): void;
		
	/**
	 * 
	 */
	setAttack(): void;
		
	/**
	 * 
	 */
	setGuard(): void;
		
	/**
	 * 
	 * @param skillId 
	 */
    setSkill(skillId: number): void;
		
	/**
	 * 
	 * @param itemId 
	 */
    setItem(itemId: number): void;
		
	/**
	 * 
	 * @param object 
	 */
    setItemObject(object: IDataItem): void;
		
	/**
	 * 
	 * @param targetIndex 
	 */
	setTarget(targetIndex : number): void;
		
	/**
	 * 
	 */
	item(): void;
		
	/**
	 * 
	 * @return  
	 */
	isSkill(): boolean;
		
	/**
	 * 
	 * @return  
	 */
	isItem(): boolean;
		
	/**
	 * 
	 * @return  
	 */
	numRepeats(): number;
		
	/**
	 * 
	 * @param list 
	 */
	checkItemScope(list : Game_Action.prototype.CheckItemScope0): void;
		
	/**
	 * 
	 */
	isForOpponent(): void;
		
	/**
	 * 
	 */
	isForFriend(): void;
		
	/**
	 * 
	 */
	isForDeadFriend(): void;
		
	/**
	 * 
	 */
	isForUser(): void;
		
	/**
	 * 
	 */
	isForOne(): void;
		
	/**
	 * 
	 */
	isForRandom(): void;
		
	/**
	 * 
	 */
	isForAll(): void;
		
	/**
	 * 
	 */
	needsSelection(): void;
		
	/**
	 * 
	 * @return  
	 */
	numTargets(): number;
		
	/**
	 * 
	 * @param list 
	 */
	checkDamageType(list : Game_Action.prototype.CheckDamageType0): void;
		
	/**
	 * 
	 */
	isHpEffect(): void;
		
	/**
	 * 
	 */
	isMpEffect(): void;
		
	/**
	 * 
	 */
	isDamage(): void;
		
	/**
	 * 
	 */
	isRecover(): void;
		
	/**
	 * 
	 */
	isDrain(): void;
		
	/**
	 * 
	 */
	isHpRecover(): void;
		
	/**
	 * 
	 */
	isMpRecover(): void;
		
	/**
	 * 
	 * @return  
	 */
	isCertainHit(): boolean;
		
	/**
	 * 
	 * @return  
	 */
	isPhysical(): boolean;
		
	/**
	 * 
	 * @return  
	 */
	isMagical(): boolean;
		
	/**
	 * 
	 * @return  
	 */
	isAttack(): boolean;
		
	/**
	 * 
	 * @return  
	 */
	isGuard(): boolean;
		
	/**
	 * 
	 * @return  
	 */
	isMagicSkill(): boolean;
		
	/**
	 * 
	 */
	decideRandomTarget(): void;
		
	/**
	 * 
	 */
	setConfusion(): void;
		
	/**
	 * 
	 */
	prepare(): void;
		
	/**
	 * 
	 * @return  
	 */
    isValid(): /* !this._forcing */ boolean;
		
	/**
	 * 
	 */
	speed(): void;
		
	/**
	 * 
	 * @return  
	 */
	makeTargets(): Game_Action.prototype.MakeTargetsRet;
		
	/**
	 * 
	 * @param targets 
	 * @return  
	 */
	repeatTargets(targets : Game_Action.prototype.RepeatTargets0): Game_Action.prototype.RepeatTargetsRet;
		
	/**
	 * 
	 */
	confusionTarget(): void;
		
	/**
	 * 
	 * @return  
	 */
	targetsForOpponents(): Game_Action.prototype.TargetsForOpponentsRet;
		
	/**
	 * 
	 * @return  
	 */
	targetsForFriends(): Game_Action.prototype.TargetsForFriendsRet;
		
	/**
	 * 
	 * @return  
	 */
	evaluate(): number;
		
	/**
	 * 
	 * @return  
	 */
	itemTargetCandidates(): Game_Action.prototype.ItemTargetCandidatesRet;
		
	/**
	 * 
	 * @param target 
	 * @return  
	 */
    evaluateWithTarget(target: /* Game_Action.prototype.+Game_BattlerBase */ Game_Battler): number;
		
	/**
	 * 
	 * @param target 
	 * @return  
	 */
    testApply(target: Game_Battler): boolean;
		
	/**
	 * 
	 * @param target 
	 */
    hasItemAnyValidEffects(target: Game_Battler): void;
		
	/**
	 * 
	 * @param target 
	 * @param effect 
	 * @return  
	 */
    testItemEffect(target: /* Game_Action.prototype.+Game_Actor */ Game_Battler, effect: IDataEffect): boolean;
		
	/**
	 * 
	 * @param target 
	 * @return  
	 */
    itemCnt(target: Game_Battler):  /* error */ number;
		
	/**
	 * 
	 * @param target 
	 * @return  
	 */
    itemMrf(target: Game_Battler):  /* error */ number;
		
	/**
	 * 
	 * @param target 
	 * @return  
	 */
    itemHit(target: Game_Battler): number;
		
	/**
	 * 
	 * @param target 
	 * @return  
	 */
    itemEva(target: Game_Battler):  /* error */ number;
		
	/**
	 * 
	 * @param target 
	 * @return  
	 */
    itemCri(target: Game_Battler): number;
		
	/**
	 * 
	 * @param target 
	 */
    apply(target: Game_Battler): void;
		
	/**
	 * 
	 * @param target 
	 * @param critical 
	 * @return  
	 */
    makeDamageValue(target: number, critical : boolean): number;
		
	/**
	 * 
	 * @param target 
	 * @return  
	 */
    evalDamageFormula(target: number): number;
		
	/**
	 * 
	 * @param target 
	 * @return  
	 */
    calcElementRate(target: number): number;
		
	/**
	 * 
	 * @param target 
	 * @param elements 
	 * @return  
	 */
    elementsMaxRate(target: number, elements: number[]): number;
		
	/**
	 * 
	 * @param damage 
	 * @return  
	 */
	applyCritical(damage : number): number;
		
	/**
	 * 
	 * @param damage 
	 * @param variance 
	 * @return  
	 */
    applyVariance(damage: number, variance: number): number;
		
	/**
	 * 
	 * @param damage 
	 * @param target 
	 * @return  
	 */
    applyGuard(damage: number, target: Game_Battler): number;
		
	/**
	 * 
	 * @param target 
	 * @param value 
	 */
    executeDamage(target: /* Game_Action.prototype.+Game_Battler */ Game_Battler, value : number): void;
		
	/**
	 * 
	 * @param target 
	 * @param value 
	 */
    executeHpDamage(target: Game_Battler, value : number): void;
		
	/**
	 * 
	 * @param target 
	 * @param value 
	 */
    executeMpDamage(target: Game_Battler, value : number): void;
		
	/**
	 * 
	 * @param value 
	 */
	gainDrainedHp(value : number): void;
		
	/**
	 * 
	 * @param value 
	 */
	gainDrainedMp(value : number): void;
		
	/**
	 * 
	 * @param target 
	 * @param effect 
	 */
    applyItemEffect(target: Game_Battler, effect: IDataEffect): void;
		
	/**
	 * 
	 * @param target 
	 * @param effect 
	 */
    itemEffectRecoverHp(target: Game_Battler, effect: IDataEffect): void;
		
	/**
	 * 
	 * @param target 
	 * @param effect 
	 */
    itemEffectRecoverMp(target: Game_Battler, effect: IDataEffect): void;
		
	/**
	 * 
	 * @param target 
	 * @param effect 
	 */
    itemEffectGainTp(target: Game_Battler, effect: IDataEffect): void;
		
	/**
	 * 
	 * @param target 
	 * @param effect 
	 */
    itemEffectAddState(target: Game_Battler, effect: IDataEffect): void;
		
	/**
	 * 
	 * @param target 
	 * @param effect 
	 */
    itemEffectAddAttackState(target: Game_Battler, effect: IDataEffect): void;
		
	/**
	 * 
	 * @param target 
	 * @param effect 
	 */
    itemEffectAddNormalState(target: Game_Battler, effect: IDataEffect): void;
		
	/**
	 * 
	 * @param target 
	 * @param effect 
	 */
    itemEffectRemoveState(target: Game_Battler, effect: IDataEffect): void;
		
	/**
	 * 
	 * @param target 
	 * @param effect 
	 */
    itemEffectAddBuff(target: Game_Battler, effect: IDataEffect): void;
		
	/**
	 * 
	 * @param target 
	 * @param effect 
	 */
    itemEffectAddDebuff(target: Game_Battler, effect: IDataEffect): void;
		
	/**
	 * 
	 * @param target 
	 * @param effect 
	 */
    itemEffectRemoveBuff(target: Game_Battler, effect: IDataEffect): void;
		
	/**
	 * 
	 * @param target 
	 * @param effect 
	 */
    itemEffectRemoveDebuff(target: Game_Battler, effect: IDataEffect): void;
		
	/**
	 * 
	 * @param target 
	 * @param effect 
	 */
    itemEffectSpecial(target: Game_Battler, effect: IDataEffect): void;
		
	/**
	 * 
	 * @param target 
	 * @param effect 
	 */
    itemEffectGrow(target: Game_Battler, effect: IDataEffect): void;
		
	/**
	 * 
	 * @param target 
	 * @param effect 
	 */
    itemEffectLearnSkill(target: Game_Battler, effect: IDataEffect): void;
		
	/**
	 * 
	 * @param target 
	 * @param effect 
	 */
    itemEffectCommonEvent(target: Game_Battler, effect: IDataEffect): void;
		
	/**
	 * 
	 * @param target 
	 */
    makeSuccess(target: Game_Battler): void;
		
	/**
	 * 
	 * @param target 
	 */
    applyItemUserEffect(target: Game_Battler): void;
		
	/**
	 * 
	 * @param target 
	 * @return  
	 */
    lukEffectRate(target: Game_Battler): number;
		
	/**
	 * 
	 */
	applyGlobal(): void;
		
	/**
	 * 
	 */
	EFFECT_RECOVER_HP : number;
		
	/**
	 * 
	 */
	EFFECT_RECOVER_MP : number;
		
	/**
	 * 
	 */
	EFFECT_GAIN_TP : number;
		
	/**
	 * 
	 */
	EFFECT_ADD_STATE : number;
		
	/**
	 * 
	 */
	EFFECT_REMOVE_STATE : number;
		
	/**
	 * 
	 */
	EFFECT_ADD_BUFF : number;
		
	/**
	 * 
	 */
	EFFECT_ADD_DEBUFF : number;
		
	/**
	 * 
	 */
	EFFECT_REMOVE_BUFF : number;
		
	/**
	 * 
	 */
	EFFECT_REMOVE_DEBUFF : number;
		
	/**
	 * 
	 */
	EFFECT_SPECIAL : number;
		
	/**
	 * 
	 */
	EFFECT_GROW : number;
		
	/**
	 * 
	 */
	EFFECT_LEARN_SKILL : number;
		
	/**
	 * 
	 */
	EFFECT_COMMON_EVENT : number;
		
	/**
	 * 
	 */
	SPECIAL_EFFECT_ESCAPE : number;
		
	/**
	 * 
	 */
	HITTYPE_CERTAIN : number;
		
	/**
	 * 
	 */
	HITTYPE_PHYSICAL : number;
		
	/**
	 * 
	 */
	HITTYPE_MAGICAL : number;
		
	/**
	 * 
	 */
	_subjectActorId : number;
		
	/**
	 * 
	 */
	_subjectEnemyIndex : number;
		
	/**
	 * 
	 */
	_targetIndex : number;
}

/**
 * -----------------------------------------------------------------------------
 * Game_ActionResult
 * 
 * The game object class for a result of a battle action. For convinience, all
 * member variables in this class are public.
 */
declare interface Game_ActionResult {
		
	/**
	 * 
	 */
	new ();
		
	/**
	 * 
	 */
	initialize(): void;
		
	/**
	 * 
	 */
	clear(): void;
		
	/**
	 * 
	 * @return  
	 */
	addedStateObjects(): Game_ActionResult.prototype.AddedStateObjectsRet;
		
	/**
	 * 
	 * @return  
	 */
	removedStateObjects(): Game_ActionResult.prototype.RemovedStateObjectsRet;
		
	/**
	 * 
	 * @return  
	 */
	isStatusAffected(): boolean;
		
	/**
	 * 
	 * @return  
	 */
    isHit(): /* !this.used */ boolean;
		
	/**
	 * 
	 * @param stateId 
	 */
    isStateAdded(stateId: number): boolean;
		
	/**
	 * 
	 * @param stateId 
	 */
	pushAddedState(stateId : number): void;
		
	/**
	 * 
	 * @param stateId 
	 */
    isStateRemoved(stateId: number): boolean;
		
	/**
	 * 
	 * @param stateId 
	 */
	pushRemovedState(stateId : number): void;
		
	/**
	 * 
	 * @param paramId 
	 */
    isBuffAdded(paramId: number): void;
		
	/**
	 * 
	 * @param paramId 
	 */
    pushAddedBuff(paramId: number): void;
		
	/**
	 * 
	 * @param paramId 
	 */
    isDebuffAdded(paramId: number): void;
		
	/**
	 * 
	 * @param paramId 
	 */
    pushAddedDebuff(paramId: number): void;
		
	/**
	 * 
	 * @param paramId 
	 */
	isBuffRemoved(paramId : number): void;
		
	/**
	 * 
	 * @param paramId 
	 */
	pushRemovedBuff(paramId : number): void;
		
	/**
	 * 
	 */
	used : boolean;
		
	/**
	 * 
	 */
	missed : boolean;
		
	/**
	 * 
	 */
	evaded : boolean;
		
	/**
	 * 
	 */
	physical : boolean;
		
	/**
	 * 
	 */
	drain : boolean;
		
	/**
	 * 
	 */
	critical : boolean;
		
	/**
	 * 
	 */
	success : boolean;
		
	/**
	 * 
	 */
	hpAffected : boolean;
		
	/**
	 * 
	 */
	hpDamage : number;
		
	/**
	 * 
	 */
	mpDamage : number;
		
	/**
	 * 
	 */
	tpDamage : number;
		
	/**
	 * 
	 */
    addedStates: Array<IDataState>;
		
	/**
	 * 
	 */
    removedStates: Array<IDataState>;
		
	/**
	 * 
	 */
    addedBuffs: Array<number>;
		
	/**
	 * 
	 */
    addedDebuffs: Array<number>;
		
	/**
	 * 
	 */
    removedBuffs: Array<number>;
}

/**
 * -----------------------------------------------------------------------------
 * Game_BattlerBase
 * 
 * The superclass of Game_Battler. It mainly contains parameters calculation.
 */
declare interface Game_BattlerBase {
		
	/**
	 * 
	 */
	new ();
		
	/**
	 * 
	 */
	//TODO:initialize(): void;
		
	/**
	 * 
	 */
	initMembers(): void;
		
	/**
	 * 
	 */
	clearParamPlus(): void;
		
	/**
	 * 
	 */
	clearStates(): void;
		
	/**
	 * 
	 * @param stateId 
	 */
    eraseState(stateId: number): void;
		
	/**
	 * 
	 * @param stateId 
	 */
	isStateAffected(stateId : number): void;
		
	/**
	 * 
	 */
    isDeathStateAffected(): boolean;
		
	/**
	 * 
	 * @return  
	 */
	deathStateId(): number;
		
	/**
	 * 
	 * @param stateId 
	 */
	resetStateCounts(stateId : number): void;
		
	/**
	 * 
	 * @param stateId 
	 * @return  
	 */
    isStateExpired(stateId: number): boolean;
		
	/**
	 * 
	 */
	updateStateTurns(): void;
		
	/**
	 * 
	 */
	clearBuffs(): void;
		
	/**
	 * 
	 * @param paramId 
	 */
    eraseBuff(paramId: number): void;
		
	/**
	 * 
	 * @return  
	 */
    buffLength(): /* !this._buffs.length */ number;
		
	/**
	 * 
	 * @param paramId 
	 * @return  
	 */
    buff(paramId: number): /* !this._buffs.<i> */ number;
		
	/**
	 * 
	 * @param paramId 
	 * @return  
	 */
    isBuffAffected(paramId: number): boolean;
		
	/**
	 * 
	 * @param paramId 
	 * @return  
	 */
    isDebuffAffected(paramId: number): boolean;
		
	/**
	 * 
	 * @param paramId 
	 * @return  
	 */
	isBuffOrDebuffAffected(paramId : number): boolean;
		
	/**
	 * 
	 * @param paramId 
	 * @return  
	 */
    isMaxBuffAffected(paramId: number): boolean;
		
	/**
	 * 
	 * @param paramId 
	 * @return  
	 */
    isMaxDebuffAffected(paramId: number): boolean;
		
	/**
	 * 
	 * @param paramId 
	 */
    increaseBuff(paramId: number): void;
		
	/**
	 * 
	 * @param paramId 
	 */
    decreaseBuff(paramId: number): void;
		
	/**
	 * 
	 * @param paramId 
	 * @param turns 
	 */
    overwriteBuffTurns(paramId: number, turns: number): void;
		
	/**
	 * 
	 * @param paramId 
	 * @return  
	 */
    isBuffExpired(paramId: number): boolean;
		
	/**
	 * 
	 */
	updateBuffTurns(): void;
		
	/**
	 * 
	 */
	die(): void;
		
	/**
	 * 
	 */
	revive(): void;
		
	/**
	 * 
	 * @return  
	 */
	states(): Game_BattlerBase.prototype.StatesRet;
		
	/**
	 * 
	 * @return  
	 */
	stateIcons(): Game_BattlerBase.prototype.StateIconsRet;
		
	/**
	 * 
	 * @return  
	 */
	buffIcons(): Game_BattlerBase.prototype.BuffIconsRet;
		
	/**
	 * 
	 * @param buffLevel 
	 * @param paramId 
	 * @return  
	 */
	buffIconIndex(buffLevel : number, paramId : number): number;
		
	/**
	 * 
	 * @return  
	 */
    allIcons(): Array<number>;
		
	/**
	 * 
	 * @return  
	 */
    traitObjects(): Array<IDataState>;
		
	/**
	 * 
	 * @return  
	 */
	allTraits(): Game_BattlerBase.prototype.AllTraitsRet;
		
	/**
	 * 
	 * @param code 
	 * @return  
	 */
    traits(code: number): Array<IDataTrait>;
		
	/**
	 * 
	 * @param code 
	 * @param id 
	 * @return  
	 */
    traitsWithId(code: number, id: number): Array<IDataTrait>;
		
	/**
	 * 
	 * @param code 
	 * @param id 
	 * @return  
	 */
    traitsPi(code: number, id: number): number;
		
	/**
	 * 
	 * @param code 
	 * @param id 
	 */
    traitsSum(code: number, id: number): number;
		
	/**
	 * 
	 * @param code 
	 */
    traitsSumAll(code: number): number;
		
	/**
	 * 
	 * @param code 
	 * @return  
	 */
	traitsSet(code : number): Game_BattlerBase.prototype.TraitsSetRet;
		
	/**
	 * 
	 * @param paramId 
	 * @return  
	 */
    //TODO:paramBase(paramId: number): number;
		
	/**
	 * 
	 * @param paramId 
	 * @return  
	 */
    paramPlus(paramId: number): /* !this._paramPlus.<i> */ number;
		
	/**
	 * 
	 * @param paramId 
	 * @return  
	 */
    paramMin(paramId: number): number;
		
	/**
	 * 
	 * @param paramId 
	 * @return  
	 */
    paramMax(paramId: number): number;
		
	/**
	 * 
	 * @param paramId 
	 * @return  
	 */
    paramRate(paramId: number): number;
		
	/**
	 * 
	 * @param paramId 
	 * @return  
	 */
    paramBuffRate(paramId: number): number;
		
	/**
	 * 
	 * @param paramId 
	 * @return  
	 */
    param(paramId: number): number;
		
	/**
	 * 
	 * @param xparamId 
	 */
    xparam(xparamId: number): void;
		
	/**
	 * 
	 * @param sparamId 
	 * @return  
	 */
    sparam(sparamId: number): number;
		
	/**
	 * 
	 * @param elementId 
	 * @return  
	 */
    elementRate(elementId: number): number;
		
	/**
	 * 
	 * @param paramId 
	 * @return  
	 */
    debuffRate(paramId: number): number;
		
	/**
	 * 
	 * @param stateId 
	 * @return  
	 */
    stateRate(stateId: number): number;
		
	/**
	 * 
	 * @return  
	 */
    stateResistSet(): Array<number>;
		
	/**
	 * 
	 * @param stateId 
	 */
	isStateResist(stateId : number): void;
		
	/**
	 * 
	 * @return  
	 */
	attackElements(): Array<number>;
		
	/**
	 * 
	 * @return  
	 */
	attackStates(): Array<number>;
		
	/**
	 * 
	 * @param stateId 
	 */
    attackStatesRate(stateId: number): number;
		
	/**
	 * 
	 */
    attackSpeed(): number;
		
	/**
	 * 
	 * @return  
	 */
	attackTimesAdd(): number;
		
	/**
	 * 
	 * @return  
	 */
	addedSkillTypes(): Array<number>;
		
	/**
	 * 
	 * @param stypeId 
	 */
    isSkillTypeSealed(stypeId: number): boolean;
		
	/**
	 * 
	 * @return  
	 */
	addedSkills(): Array<number>;
		
	/**
	 * 
	 * @param skillId 
	 */
    isSkillSealed(skillId: number): boolean;
		
	/**
	 * 
	 * @param wtypeId 
	 */
    isEquipWtypeOk(wtypeId: number): boolean;
		
	/**
	 * 
	 * @param atypeId 
	 */
    isEquipAtypeOk(atypeId: number): boolean;
		
	/**
	 * 
	 * @param etypeId 
	 */
    isEquipTypeLocked(etypeId: number): boolean;
		
	/**
	 * 
	 * @param etypeId 
	 */
    isEquipTypeSealed(etypeId: number): boolean;
		
	/**
	 * 
	 * @return  
	 */
	slotType(): number;
		
	/**
	 * 
	 * @return  
	 */
	isDualWield(): boolean;
		
	/**
	 * 
	 * @return  
	 */
	actionPlusSet(): Game_BattlerBase.prototype.ActionPlusSetRet;
		
	/**
	 * 
	 * @param flagId 
	 * @return  
	 */
	specialFlag(flagId : number): boolean;
		
	/**
	 * 
	 * @return  
	 */
	collapseType(): number;
		
	/**
	 * 
	 * @param abilityId 
	 * @return  
	 */
    partyAbility(abilityId: number): boolean;
		
	/**
	 * 
	 * @return  
	 */
	isAutoBattle(): boolean;
		
	/**
	 * 
	 * @return  
	 */
	isGuard(): boolean;
		
	/**
	 * 
	 * @return  
	 */
	isSubstitute(): boolean;
		
	/**
	 * 
	 * @return  
	 */
	isPreserveTp(): boolean;
		
	/**
	 * 
	 * @param paramId 
	 * @param value 
	 */
    addParam(paramId: number, value: number): void;
		
	/**
	 * 
	 * @param hp 
	 */
    setHp(hp: number): void;
		
	/**
	 * 
	 * @param mp 
	 */
    setMp(mp: number): void;
		
	/**
	 * 
	 * @param tp 
	 */
    setTp(tp: number): void;
		
	/**
	 * 
	 * @return  
	 */
	maxTp(): number;
		
	/**
	 * 
	 */
	refresh(): void;
		
	/**
	 * 
	 */
	recoverAll(): void;
		
	/**
	 * 
	 * @return  
	 */
	hpRate(): number;
		
	/**
	 * 
	 * @return  
	 */
	mpRate(): number;
		
	/**
	 * 
	 * @return  
	 */
	tpRate(): number;
		
	/**
	 * 
	 */
	hide(): void;
		
	/**
	 * 
	 */
	appear(): void;
		
	/**
	 * 
	 * @return  
	 */
    isHidden(): /* !this._hidden */ boolean;
		
	/**
	 * 
	 * @return  
	 */
	isAppeared(): boolean;
		
	/**
	 * 
	 * @return  
	 */
	isDead(): boolean;
		
	/**
	 * 
	 * @return  
	 */
	isAlive(): boolean;
		
	/**
	 * 
	 * @return  
	 */
	isDying(): boolean;
		
	/**
	 * 
	 * @return  
	 */
	isRestricted(): boolean;
		
	/**
	 * 
	 * @return  
	 */
	canInput(): boolean;
		
	/**
	 * 
	 * @return  
	 */
	canMove(): boolean;
		
	/**
	 * 
	 * @return  
	 */
	isConfused(): boolean;
		
	/**
	 * 
	 * @return  
	 */
	confusionLevel(): number;
		
	/**
	 * 
	 * @return  
	 */
	isActor(): boolean;
		
	/**
	 * 
	 * @return  
	 */
	isEnemy(): boolean;
		
	/**
	 * 
	 */
	sortStates(): void;
		
	/**
	 * 
	 * @return  
	 */
	restriction(): number;
		
	/**
	 * 
	 * @param stateId 
	 */
	addNewState(stateId : number): void;
		
	/**
	 * 
	 */
	onRestrict(): void;
		
	/**
	 * 
	 * @return  
	 */
	mostImportantStateText(): string;
		
	/**
	 * 
	 * @return  
	 */
	stateMotionIndex(): number;
		
	/**
	 * 
	 * @return  
	 */
	stateOverlayIndex(): number;
		
	/**
	 * 
	 * @param skill 
	 * @return  
	 */
    isSkillWtypeOk(skill: IDataSkill): boolean;
		
	/**
	 * 
	 * @param skill 
	 * @return  
	 */
    skillMpCost(skill: IDataSkill): number;
		
	/**
	 * 
	 * @param skill 
	 * @return  
	 */
    skillTpCost(skill: IDataSkill):  /* error */ number;
		
	/**
	 * 
	 * @param skill 
	 * @return  
	 */
    canPaySkillCost(skill: IDataSkill): boolean;
		
	/**
	 * 
	 * @param skill 
	 */
    paySkillCost(skill: IDataSkill): void;
		
	/**
	 * 
	 * @param item 
	 * @return  
	 */
    isOccasionOk(item: IDataAllItem): boolean;
		
	/**
	 * 
	 * @param item 
	 * @return  
	 */
    meetsUsableItemConditions(item: IDataAllItem): boolean;
		
	/**
	 * 
	 * @param skill 
	 * @return  
	 */
    meetsSkillConditions(skill: IDataSkill): boolean;
		
	/**
	 * 
	 * @param item 
	 * @return  
	 */
    meetsItemConditions(item: IDataAllItem): boolean;
		
	/**
	 * 
	 * @param item 
	 * @return  
	 */
    canUse(item: IDataAllItem): boolean;
		
	/**
	 * 
	 * @param item 
	 * @return  
	 */
    canEquip(item: IDataAllItem): boolean;
		
	/**
	 * 
	 * @param item 
	 * @return  
	 */
    canEquipWeapon(item: IDataAllItem): boolean;
		
	/**
	 * 
	 * @param item 
	 * @return  
	 */
    canEquipArmor(item: IDataAllItem): boolean;
		
	/**
	 * 
	 * @return  
	 */
	attackSkillId(): number;
		
	/**
	 * 
	 * @return  
	 */
	guardSkillId(): number;
		
	/**
	 * 
	 * @return  
	 */
	canAttack(): boolean;
		
	/**
	 * 
	 * @return  
	 */
	canGuard(): boolean;
		
	/**
	 * 
	 */
	TRAIT_ELEMENT_RATE : number;
		
	/**
	 * 
	 */
	TRAIT_DEBUFF_RATE : number;
		
	/**
	 * 
	 */
	TRAIT_STATE_RATE : number;
		
	/**
	 * 
	 */
	TRAIT_STATE_RESIST : number;
		
	/**
	 * 
	 */
	TRAIT_PARAM : number;
		
	/**
	 * 
	 */
	TRAIT_XPARAM : number;
		
	/**
	 * 
	 */
	TRAIT_SPARAM : number;
		
	/**
	 * 
	 */
	TRAIT_ATTACK_ELEMENT : number;
		
	/**
	 * 
	 */
	TRAIT_ATTACK_STATE : number;
		
	/**
	 * 
	 */
	TRAIT_ATTACK_SPEED : number;
		
	/**
	 * 
	 */
	TRAIT_ATTACK_TIMES : number;
		
	/**
	 * 
	 */
	TRAIT_STYPE_ADD : number;
		
	/**
	 * 
	 */
	TRAIT_STYPE_SEAL : number;
		
	/**
	 * 
	 */
	TRAIT_SKILL_ADD : number;
		
	/**
	 * 
	 */
	TRAIT_SKILL_SEAL : number;
		
	/**
	 * 
	 */
	TRAIT_EQUIP_WTYPE : number;
		
	/**
	 * 
	 */
	TRAIT_EQUIP_ATYPE : number;
		
	/**
	 * 
	 */
	TRAIT_EQUIP_LOCK : number;
		
	/**
	 * 
	 */
	TRAIT_EQUIP_SEAL : number;
		
	/**
	 * 
	 */
	TRAIT_SLOT_TYPE : number;
		
	/**
	 * 
	 */
	TRAIT_ACTION_PLUS : number;
		
	/**
	 * 
	 */
	TRAIT_SPECIAL_FLAG : number;
		
	/**
	 * 
	 */
	TRAIT_COLLAPSE_TYPE : number;
		
	/**
	 * 
	 */
	TRAIT_PARTY_ABILITY : number;
		
	/**
	 * 
	 */
	FLAG_ID_AUTO_BATTLE : number;
		
	/**
	 * 
	 */
	FLAG_ID_GUARD : number;
		
	/**
	 * 
	 */
	FLAG_ID_SUBSTITUTE : number;
		
	/**
	 * 
	 */
	FLAG_ID_PRESERVE_TP : number;
		
	/**
	 * 
	 */
	ICON_BUFF_START : number;
		
	/**
	 * 
	 */
	ICON_DEBUFF_START : number;
		
	/**
	 * 
	 */
	_hp : number;
		
	/**
	 * 
	 */
	_mp : number;
		
	/**
	 * 
	 */
	_tp : number;
		
	/**
	 * 
	 */
	_hidden : boolean;
		
	/**
	 * 
	 */
	_paramPlus : Array<number>;
		
	/**
	 * 
	 */
	_states : Array<number>;
		
	/**
	 * 
	 */
    _stateTurns: /*no type*/{ [key: number]: number};
		
	/**
	 * 
	 */
    _buffs: Array<number>;
		
	/**
	 * 
	 */
    _buffTurns: Array<number>;
}

/**
 * -----------------------------------------------------------------------------
 * Game_Battler
 * 
 * The superclass of Game_Actor and Game_Enemy. It contains methods for sprites
 * and actions.
 */
//declare interface Game_Battler extends Game_BattlerBase {
declare interface Game_Battler extends Game_BattlerBase {		
	/**
	 * 
	 */
	new ();
		
	/**
	 * 
	 */
	//TODO:initialize(): void;
		
	/**
	 * 
	 */
	initMembers(): void;
		
	/**
	 * 
	 */
	clearAnimations(): void;
		
	/**
	 * 
	 */
	clearDamagePopup(): void;
		
	/**
	 * 
	 */
	clearWeaponAnimation(): void;
		
	/**
	 * 
	 */
	clearEffect(): void;
		
	/**
	 * 
	 */
	clearMotion(): void;
		
	/**
	 * 
	 * @param effectType 
	 */
	requestEffect(effectType : string): void;
		
	/**
	 * 
	 * @param motionType 
	 */
	requestMotion(motionType : string): void;
		
	/**
	 * 
	 */
	requestMotionRefresh(): void;
		
	/**
	 * 
	 */
	select(): void;
		
	/**
	 * 
	 */
	deselect(): void;
		
	/**
	 * 
	 * @return  
	 */
	isAnimationRequested(): boolean;
		
	/**
	 * 
	 * @return  
	 */
    isDamagePopupRequested(): /* !this._damagePopup */ boolean;
		
	/**
	 * 
	 * @return  
	 */
	isEffectRequested(): boolean;
		
	/**
	 * 
	 * @return  
	 */
	isMotionRequested(): boolean;
		
	/**
	 * 
	 * @return  
	 */
	isWeaponAnimationRequested(): boolean;
		
	/**
	 * 
	 * @return  
	 */
    isMotionRefreshRequested(): /* !this._motionRefresh */ boolean;
		
	/**
	 * 
	 * @return  
	 */
    isSelected(): /* !this._selected */ boolean;
		
	/**
	 * 
	 * @return  
	 */
    effectType(): /* !this._effectType */ string;
		
	/**
	 * 
	 * @return  
	 */
    motionType(): /* !this._motionType */ string;
		
	/**
	 * 
	 * @return  
	 */
    weaponImageId(): /* !this._weaponImageId */ number;
		
	/**
	 * 
	 * @return  
	 */
	shiftAnimation(): Game_Battler.prototype.ShiftAnimationRet;
		
	/**
	 * 
	 * @param animationId 
	 * @param mirror 
	 * @param delay 
	 */
    startAnimation(animationId: number, mirror: boolean, delay: number): void;
		
	/**
	 * 
	 */
	startDamagePopup(): void;
		
	/**
	 * 
	 * @param weaponImageId 
	 */
    startWeaponAnimation(weaponImageId: number): void;
		
	/**
	 * 
	 * @param index 
	 * @return  
	 */
    action(index: number): /* !this._actions.<i> */ Game_Action;
		
	/**
	 * 
	 * @param index 
	 * @param action 
	 */
	setAction(index : number, action : Game_Action): void;
		
	/**
	 * 
	 * @return  
	 */
    numActions(): /* !this._actions.length */ number;
		
	/**
	 * 
	 */
	clearActions(): void;
		
	/**
	 * 
	 * @return  
	 */
    result(): /* !this._result */ Game_ActionResult;
		
	/**
	 * 
	 */
	clearResult(): void;
		
	/**
	 * 
	 */
	refresh(): void;
		
	/**
	 * 
	 * @param stateId 
	 */
	addState(stateId : number): void;
		
	/**
	 * 
	 * @param stateId 
	 * @return  
	 */
	isStateAddable(stateId : number): boolean;
		
	/**
	 * 
	 * @param stateId 
	 * @return  
	 */
	isStateRestrict(stateId : number): boolean;
		
	/**
	 * 
	 */
	onRestrict(): void;
		
	/**
	 * 
	 * @param stateId 
	 */
	removeState(stateId : number): void;
		
	/**
	 * 
	 */
	escape(): void;
		
	/**
	 * 
	 * @param paramId 
	 * @param turns 
	 */
    addBuff(paramId: number, turns: number): void;
		
	/**
	 * 
	 * @param paramId 
	 * @param turns 
	 */
    addDebuff(paramId : number, turns: number): void;
		
	/**
	 * 
	 * @param paramId 
	 */
    removeBuff(paramId: number): void;
		
	/**
	 * 
	 */
	removeBattleStates(): void;
		
	/**
	 * 
	 */
	removeAllBuffs(): void;
		
	/**
	 * 
	 * @param timing 
	 */
	removeStatesAuto(timing : number): void;
		
	/**
	 * 
	 */
	removeBuffsAuto(): void;
		
	/**
	 * 
	 */
	removeStatesByDamage(): void;
		
	/**
	 * 
	 * @return  
	 */
	makeActionTimes(): number;
		
	/**
	 * 
	 */
	makeActions(): void;
		
	/**
	 * 
	 * @return  
	 */
    speed(): /* !this._speed */ number;
		
	/**
	 * 
	 */
	makeSpeed(): void;
		
	/**
	 * 
	 * @return  
	 */
    currentAction(): /* !this._actions.0 */ Game_Action;
		
	/**
	 * 
	 */
	removeCurrentAction(): void;
		
	/**
	 * 
	 * @param target 
	 */
    setLastTarget(target: /* Game_Battler.prototype.+Game_Enemy */ Game_Enemy): void;
		
	/**
	 * 
	 * @param skillId 
	 * @param targetIndex 
	 */
    forceAction(skillId: number, targetIndex: number): void;
		
	/**
	 * 
	 * @param item 
	 */
	useItem(item : IDataAllItem): void;
		
	/**
	 * 
	 * @param item 
	 */
	consumeItem(item : IDataAllItem): void;
		
	/**
	 * 
	 * @param value 
	 */
	gainHp(value : number): void;
		
	/**
	 * 
	 * @param value 
	 */
	gainMp(value : number): void;
		
	/**
	 * 
	 * @param value 
	 */
	gainTp(value : number): void;
		
	/**
	 * 
	 * @param value 
	 */
	gainSilentTp(value : number): void;
		
	/**
	 * 
	 */
	initTp(): void;
		
	/**
	 * 
	 */
	clearTp(): void;
		
	/**
	 * 
	 * @param damageRate 
	 */
	chargeTpByDamage(damageRate : number): void;
		
	/**
	 * 
	 */
	regenerateHp(): void;
		
	/**
	 * 
	 * @return  
	 */
    maxSlipDamage(): /* !this.hp */ number;
		
	/**
	 * 
	 */
	regenerateMp(): void;
		
	/**
	 * 
	 */
	regenerateTp(): void;
		
	/**
	 * 
	 */
	regenerateAll(): void;
		
	/**
	 * 
	 */
	onBattleStart(): void;
		
	/**
	 * 
	 */
	onAllActionsEnd(): void;
		
	/**
	 * 
	 */
	onTurnEnd(): void;
		
	/**
	 * 
	 */
	onBattleEnd(): void;
		
	/**
	 * 
	 * @param value 
	 */
    onDamage(value: number): void;
		
	/**
	 * 
	 * @param actionState 
	 */
	setActionState(actionState : string): void;
		
	/**
	 * 
	 * @return  
	 */
	isUndecided(): boolean;
		
	/**
	 * 
	 * @return  
	 */
	isInputting(): boolean;
		
	/**
	 * 
	 * @return  
	 */
	isWaiting(): boolean;
		
	/**
	 * 
	 * @return  
	 */
	isActing(): boolean;
		
	/**
	 * 
	 * @return  
	 */
	isChanting(): boolean;
		
	/**
	 * 
	 * @return  
	 */
	isGuardWaiting(): boolean;
		
	/**
	 * 
	 * @param action 
	 */
	performActionStart(action : Game_Action): void;
		
	/**
	 * 
	 * @param action 
	 */
	performAction(action : Game_Action): void;
		
	/**
	 * 
	 */
	performActionEnd(): void;
		
	/**
	 * 
	 */
	performDamage(): void;
		
	/**
	 * 
	 */
	performMiss(): void;
		
	/**
	 * 
	 */
	performRecovery(): void;
		
	/**
	 * 
	 */
	performEvasion(): void;
		
	/**
	 * 
	 */
	performMagicEvasion(): void;
		
	/**
	 * 
	 */
	performCounter(): void;
		
	/**
	 * 
	 */
	performReflection(): void;
		
	/**
	 * 
	 * @param target 
	 */
    performSubstitute(target: Game_Battler): void;
		
	/**
	 * 
	 */
	performCollapse(): void;
		
	/**
	 * 
	 */
	_hp : number;
		
	/**
	 * 
	 */
	_mp : number;
		
	/**
	 * 
	 */
	_tp : number;
		
	/**
	 * 
	 */
	_hidden : boolean;
		
	/**
	 * 
	 */
	_actions : Array<Game_Action>;
		
	/**
	 * 
	 */
	_speed : number;
		
	/**
	 * 
	 */
	_actionState : string;
		
	/**
	 * 
	 */
	_lastTargetIndex : number;
		
	/**
	 * 
	 */
    _animations: Array</* Game_Actor._animations.<i> */ IGame_BattlerAnimation>;
		
	/**
	 * 
	 */
	_damagePopup : boolean;
		
	/**
	 * 
	 */
	_effectType : string;
		
	/**
	 * 
	 */
	_motionType : string;
		
	/**
	 * 
	 */
	_weaponImageId : number;
		
	/**
	 * 
	 */
	_motionRefresh : boolean;
		
	/**
	 * 
	 */
	_selected : boolean;
}

/**
 * -----------------------------------------------------------------------------
 * Game_Actor
 * 
 * The game object class for an actor.
 */
declare interface Game_Actor extends Game_Battler {
		
	/**
	 * 
	 */
	new ();
		
	/**
	 * 
	 * @param actorId 
	 */
	initialize(actorId : number): void;
		
	/**
	 * 
	 */
	initMembers(): void;
		
	/**
	 * 
	 * @param actorId 
	 */
	setup(actorId : number): void;
		
	/**
	 * 
	 * @return  
	 */
    actorId(): /* !this._actorId */ number;
		
	/**
	 * 
	 */
	actor(): void;
		
	/**
	 * 
	 * @return  
	 */
    name(): /* !this._name */ string;
		
	/**
	 * 
	 * @param name 
	 */
	setName(name : string): void;
		
	/**
	 * 
	 * @return  
	 */
    nickname(): /* !this._nickname */ string;
		
	/**
	 * 
	 * @param nickname 
	 */
	setNickname(nickname : string): void;
		
	/**
	 * 
	 * @return  
	 */
    profile(): /* !this._profile */ string;
		
	/**
	 * 
	 * @param profile 
	 */
    setProfile(profile: string): void;
		
	/**
	 * 
	 * @return  
	 */
    characterName(): /* !this._characterName */ string;
		
	/**
	 * 
	 * @return  
	 */
    characterIndex(): /* !this._characterIndex */ number;
		
	/**
	 * 
	 * @return  
	 */
    faceName(): /* !this._faceName */ string;
		
	/**
	 * 
	 * @return  
	 */
    faceIndex(): /* !this._faceIndex */ number;
		
	/**
	 * 
	 * @return  
	 */
    battlerName(): /* !this._battlerName */ number;
		
	/**
	 * 
	 */
	clearStates(): void;
		
	/**
	 * 
	 * @param stateId 
	 */
	eraseState(stateId : number): void;
		
	/**
	 * 
	 * @param stateId 
	 */
	resetStateCounts(stateId : number): void;
		
	/**
	 * 
	 */
	initImages(): void;
		
	/**
	 * 
	 * @param level 
	 * @return  
	 */
	expForLevel(level : number): number;
		
	/**
	 * 
	 */
	initExp(): void;
		
	/**
	 * 
	 * @return  
	 */
    currentExp(): /* !this._exp.<i> */ number;
		
	/**
	 * 
	 * @return  
	 */
	currentLevelExp(): number;
		
	/**
	 * 
	 * @return  
	 */
	nextLevelExp(): number;
		
	/**
	 * 
	 * @return  
	 */
	nextRequiredExp(): number;
		
	/**
	 * 
	 */
    maxLevel(): number;
		
	/**
	 * 
	 * @return  
	 */
	isMaxLevel(): boolean;
		
	/**
	 * 
	 */
	initSkills(): void;
		
	/**
	 * 
	 * @param equips 
	 */
    initEquips(equips: number[]): void;
		
	/**
	 * 
	 * @return  
	 */
	equipSlots(): Game_Actor.prototype.EquipSlotsRet;
		
	/**
	 * 
	 * @return  
	 */
	equips(): Game_Actor.prototype.EquipsRet;
		
	/**
	 * 
	 * @return  
	 */
    weapons(): Array<IDataWeapon>;
		
	/**
	 * 
	 * @return  
	 */
    armors(): Array<IDataArmor>;
		
	/**
	 * 
	 * @param weapon 
	 */
    hasWeapon(weapon: IDataWeapon): void;
		
	/**
	 * 
	 * @param armor 
	 */
    hasArmor(armor: IDataArmor): void;
		
	/**
	 * 
	 * @param slotId 
	 * @return  
	 */
	isEquipChangeOk(slotId : number): boolean;
		
	/**
	 * 
	 * @param slotId 
	 * @param item 
	 */
	changeEquip(slotId : number, item : IDataAllItem): void;
		
	/**
	 * 
	 * @param slotId 
	 * @param item 
	 */
	forceChangeEquip(slotId : number, item : IDataAllItem): void;
		
	/**
	 * 
	 * @param newItem 
	 * @param oldItem 
	 * @return  
	 */
	tradeItemWithParty(newitem : IDataAllItem, olditem : IDataAllItem): boolean;
		
	/**
	 * 
	 * @param etypeId 
	 * @param itemId 
	 */
	changeEquipById(etypeId : number, itemId : number): void;
		
	/**
	 * 
	 * @param item 
	 */
	isEquipped(item : IDataAllItem): void;
		
	/**
	 * 
	 * @param item 
	 */
	discardEquip(item : IDataAllItem): void;
		
	/**
	 * 
	 * @param forcing 
	 */
	releaseUnequippableItems(forcing : boolean): void;
		
	/**
	 * 
	 */
	clearEquipments(): void;
		
	/**
	 * 
	 */
	optimizeEquipments(): void;
		
	/**
	 * 
	 * @param slotId 
	 */
	bestEquipItem(slotId : number): void;
		
	/**
	 * 
	 * @param item 
	 */
	calcEquipItemPerformance(item : IDataAllItem): void;
		
	/**
	 * 
	 * @param skill 
	 * @return  
	 */
	isSkillWtypeOk(skill : IDataSkill): boolean;
		
	/**
	 * 
	 * @param wtypeId 
	 * @return  
	 */
	isWtypeEquipped(wtypeId : number): boolean;
		
	/**
	 * 
	 */
	refresh(): void;
		
	/**
	 * 
	 * @return  
	 */
	isActor(): boolean;
		
	/**
	 * 
	 */
	friendsUnit(): void;
		
	/**
	 * 
	 */
	opponentsUnit(): void;
		
	/**
	 * 
	 */
	index(): void;
		
	/**
	 * 
	 */
	isBattleMember(): void;
		
	/**
	 * 
	 * @return  
	 */
	isFormationChangeOk(): boolean;
		
	/**
	 * 
	 */
	currentClass(): void;
		
	/**
	 * 
	 * @param gameClass 
	 * @return  
	 */
    isClass(gameClass: IDataClass): boolean;
		
	/**
	 * 
	 * @return  
	 */
	skills(): Game_Actor.prototype.SkillsRet;
		
	/**
	 * 
	 * @return  
	 */
    usableSkills(): Array<IDataSkill>;
		
	/**
	 * 
	 * @return  
	 */
    traitObjects(): Array<IDataState>;
		
	/**
	 * 
	 * @return  
	 */
    attackElements(): Array<number>;
		
	/**
	 * 
	 * @return  
	 */
	hasNoWeapons(): boolean;
		
	/**
	 * 
	 * @return  
	 */
	bareHandsElementId(): number;
		
	/**
	 * 
	 * @param paramId 
	 * @return  
	 */
	paramMax(paramId : number): number;
		
	/**
	 * 
	 * @param paramId 
	 */
	paramBase(paramId : number): void;
		
	/**
	 * 
	 * @param paramId 
	 * @return  
	 */
	paramPlus(paramId : number): number;
		
	/**
	 * 
	 * @return  
	 */
	attackAnimationId1(): number;
		
	/**
	 * 
	 * @return  
	 */
	attackAnimationId2(): number;
		
	/**
	 * 
	 * @return  
	 */
	bareHandsAnimationId(): number;
		
	/**
	 * 
	 * @param exp 
	 * @param show 
	 */
	changeExp(exp : number, show : boolean): void;
		
	/**
	 * 
	 */
	levelUp(): void;
		
	/**
	 * 
	 */
	levelDown(): void;
		
	/**
	 * 
	 * @param lastSkills 
	 * @return  
	 */
    findNewSkills(lastSkills: Array<IDataSkill>): Array<IDataSkill>;
		
	/**
	 * 
	 * @param newSkills 
	 */
    displayLevelUp(newSkills: Array<IDataSkill>): void;
		
	/**
	 * 
	 * @param exp 
	 */
	gainExp(exp : number): void;
		
	/**
	 * 
	 * @return  
	 */
	finalExpRate(): number;
		
	/**
	 * 
	 * @return  
	 */
	benchMembersExpRate(): number;
		
	/**
	 * 
	 * @return  
	 */
	shouldDisplayLevelUp(): boolean;
		
	/**
	 * 
	 * @param level 
	 * @param show 
	 */
	changeLevel(level : number, show : boolean): void;
		
	/**
	 * 
	 * @param skillId 
	 */
	learnSkill(skillId : number): void;
		
	/**
	 * 
	 * @param skillId 
	 */
	forgetSkill(skillId : number): void;
		
	/**
	 * 
	 * @param skillId 
	 */
	isLearnedSkill(skillId : number): void;
		
	/**
	 * 
	 * @param skillId 
	 */
	hasSkill(skillId : number): void;
		
	/**
	 * 
	 * @param classId 
	 * @param keepExp 
	 */
	changeClass(classId : number, keepexp : number): void;
		
	/**
	 * 
	 * @param characterName 
	 * @param characterIndex 
	 */
	setCharacterImage(charactername : string, characterIndex : number): void;
		
	/**
	 * 
	 * @param faceName 
	 * @param faceIndex 
	 */
	setFaceImage(facename : string, faceIndex : number): void;
		
	/**
	 * 
	 * @param battlerName 
	 */
	setBattlerImage(battlername : string): void;
		
	/**
	 * 
	 */
	isSpriteVisible(): void;
		
	/**
	 * 
	 * @param animationId 
	 * @param mirror 
	 * @param delay 
	 */
	startAnimation(animationId : number, mirror : boolean, delay : number): void;
		
	/**
	 * 
	 * @param action 
	 */
	performActionStart(action : Game_Action): void;
		
	/**
	 * 
	 * @param action 
	 */
	performAction(action : Game_Action): void;
		
	/**
	 * 
	 */
	performActionEnd(): void;
		
	/**
	 * 
	 */
	performAttack(): void;
		
	/**
	 * 
	 */
	performDamage(): void;
		
	/**
	 * 
	 */
	performEvasion(): void;
		
	/**
	 * 
	 */
	performMagicEvasion(): void;
		
	/**
	 * 
	 */
	performCounter(): void;
		
	/**
	 * 
	 */
	performCollapse(): void;
		
	/**
	 * 
	 */
	performVictory(): void;
		
	/**
	 * 
	 */
	performEscape(): void;
		
	/**
	 * 
	 * @return  
	 */
	makeActionList(): Game_Actor.prototype.MakeActionListRet;
		
	/**
	 * 
	 */
	makeAutoBattleActions(): void;
		
	/**
	 * 
	 */
	makeConfusionActions(): void;
		
	/**
	 * 
	 */
	makeActions(): void;
		
	/**
	 * 
	 */
	onPlayerWalk(): void;
		
	/**
	 * 
	 * @param state 
	 */
	updateStateSteps(state : IDataState): void;
		
	/**
	 * 
	 */
	showAddedStates(): void;
		
	/**
	 * 
	 */
	showRemovedStates(): void;
		
	/**
	 * 
	 * @return  
	 */
	stepsForTurn(): number;
		
	/**
	 * 
	 */
	turnEndOnMap(): void;
		
	/**
	 * 
	 */
	checkFloorEffect(): void;
		
	/**
	 * 
	 */
	executeFloorDamage(): void;
		
	/**
	 * 
	 * @return  
	 */
	basicFloorDamage(): number;
		
	/**
	 * 
	 * @return  
	 */
    maxFloorDamage(): /* !this.hp */ number;
		
	/**
	 * 
	 */
	performMapDamage(): void;
		
	/**
	 * 
	 */
	clearActions(): void;
		
	/**
	 * 
	 * @return  
	 */
	inputtingAction(): Game_Action;
		
	/**
	 * 
	 * @return  
	 */
	selectNextCommand(): boolean;
		
	/**
	 * 
	 * @return  
	 */
	selectPreviousCommand(): boolean;
		
	/**
	 * 
	 */
	lastMenuSkill(): void;
		
	/**
	 * 
	 * @param skill 
	 */
	setLastMenuSkill(skill : IDataSkill): void;
		
	/**
	 * 
	 */
	lastBattleSkill(): void;
		
	/**
	 * 
	 * @param skill 
	 */
	setLastBattleSkill(skill : IDataSkill): void;
		
	/**
	 * 
	 * @return  
	 */
    lastCommandSymbol(): /* !this._lastCommandSymbol */ string;
		
	/**
	 * 
	 * @param symbol 
	 */
	setLastCommandSymbol(symbol : string): void;
		
	/**
	 * 
	 * @param item 
	 */
	testEscape(item : IDataAllItem): void;
		
	/**
	 * 
	 * @param item 
	 * @return  
	 */
	meetsUsableItemConditions(item : IDataAllItem): boolean;
		
	/**
	 * 
	 */
    _actions: Array</* Game_Actor.+Game_Action */ Game_Action>;
		
	/**
	 * 
	 */
	_speed : number;
		
	/**
	 * 
	 */
	_result : Game_ActionResult;
		
	/**
	 * 
	 */
	_actionState : string;
		
	/**
	 * 
	 */
	_lastTargetIndex : number;
		
	/**
	 * 
	 */
    _animations: Array</* Game_Actor._animationsI */ IGame_BattlerAnimation>;
		
	/**
	 * 
	 */
	_damagePopup : boolean;
		
	/**
	 * 
	 */
	_motionType : string;
		
	/**
	 * 
	 */
	_weaponImageId : number;
		
	/**
	 * 
	 */
	_motionRefresh : boolean;
		
	/**
	 * 
	 */
	_selected : boolean;
		
	/**
	 * 
	 */
	_hp : number;
		
	/**
	 * 
	 */
	_mp : number;
		
	/**
	 * 
	 */
	_tp : number;
		
	/**
	 * 
	 */
	_hidden : boolean;
		
	/**
	 * 
	 */
	_actorId : number;
		
	/**
	 * 
	 */
	_name : string;
		
	/**
	 * 
	 */
	_nickname : string;
		
	/**
	 * 
	 */
	_classId : number;
		
	/**
	 * 
	 */
	_level : number;
		
	/**
	 * 
	 */
	_characterName : string;
		
	/**
	 * 
	 */
	_characterIndex : number;
		
	/**
	 * 
	 */
	_faceName : string;
		
	/**
	 * 
	 */
	_faceIndex : number;
		
	/**
	 * 
	 */
	_battlerName : string;
	
	/**
	 * 
	 */
	_exp : {
	}
		
	/**
	 * 
	 */
    _skills: Array<number>;
		
	/**
	 * 
	 */
	_equips : Array<Game_Item>;
		
	/**
	 * 
	 */
	_actionInputIndex : number;
		
	/**
	 * 
	 */
	_lastMenuSkill : Game_Item;
		
	/**
	 * 
	 */
	_lastCommandSymbol : string;
		
	/**
	 * 
	 */
	_stateSteps : /*no type*/{};
}

/**
 * -----------------------------------------------------------------------------
 * Game_Enemy
 * 
 * The game object class for an enemy.
 */
declare interface Game_Enemy extends Game_Battler {
		
	/**
	 * 
	 */
	new ();
		
	/**
	 * 
	 * @param enemyId 
	 * @param x 
	 * @param y 
	 */
    initialize(enemyId: number, x: number, y: number): void;
		
	/**
	 * 
	 */
	initMembers(): void;
		
	/**
	 * 
	 * @param enemyId 
	 * @param x 
	 * @param y 
	 */
	setup(enemyId : number, x : number, y : number): void;
		
	/**
	 * 
	 * @return  
	 */
	isEnemy(): boolean;
		
	/**
	 * 
	 */
	friendsUnit(): void;
		
	/**
	 * 
	 */
	opponentsUnit(): void;
		
	/**
	 * 
	 */
	index(): void;
		
	/**
	 * 
	 * @return  
	 */
	isBattleMember(): boolean;
		
	/**
	 * 
	 * @return  
	 */
    enemyId(): /* !this._enemyId */ number;
		
	/**
	 * 
	 */
	enemy(): void;
		
	/**
	 * 
	 * @return  
	 */
    traitObjects(): Array<IDataState>;
		
	/**
	 * 
	 * @param paramId 
	 */
	paramBase(paramId : number): void;
		
	/**
	 * 
	 */
	exp(): void;
		
	/**
	 * 
	 */
	gold(): void;
		
	/**
	 * 
	 */
	makeDropItems(): void;
		
	/**
	 * 
	 * @return  
	 */
	dropItemRate(): number;
		
	/**
	 * 
	 * @param kind 
	 * @param dataId 
	 */
	itemObject(kind : number, dataId : number): void;
		
	/**
	 * 
	 * @return  
	 */
	isSpriteVisible(): boolean;
		
	/**
	 * 
	 * @return  
	 */
    screenX(): /* !this._screenX */ number;
		
	/**
	 * 
	 * @return  
	 */
    screenY(): /* !this._screenY */ number;
		
	/**
	 * 
	 */
	battlerName(): void;
		
	/**
	 * 
	 */
	battlerHue(): void;
		
	/**
	 * 
	 */
	originalName(): void;
		
	/**
	 * 
	 * @return  
	 */
	name(): string;
		
	/**
	 * 
	 * @return  
	 */
	isLetterEmpty(): boolean;
		
	/**
	 * 
	 * @param letter 
	 */
    setLetter(letter: string): void;
		
	/**
	 * 
	 * @param plural 
	 */
    setPlural(plural: string): void;
		
	/**
	 * 
	 * @param action 
	 */
	performActionStart(action : Game_Action): void;
		
	/**
	 * 
	 * @param action 
	 */
	performAction(action : Game_Action): void;
		
	/**
	 * 
	 */
	performActionEnd(): void;
		
	/**
	 * 
	 */
	performDamage(): void;
		
	/**
	 * 
	 */
	performCollapse(): void;
		
	/**
	 * 
	 * @param enemyId 
	 */
	transform(enemyId : number): void;
		
	/**
	 * 
	 * @param action 
	 * @return  
	 */
	meetsCondition(action : Game_Action): boolean;
		
	/**
	 * 
	 * @param param1 
	 * @param param2 
	 * @return  
	 */
	meetsTurnCondition(param1 : number, param2 : number): boolean;
		
	/**
	 * 
	 * @param param1 
	 * @param param2 
	 * @return  
	 */
	meetsHpCondition(param1 : number, param2 : number): boolean;
		
	/**
	 * 
	 * @param param1 
	 * @param param2 
	 * @return  
	 */
	meetsMpCondition(param1 : number, param2 : number): boolean;
		
	/**
	 * 
	 * @param param 
	 */
	meetsStateCondition(param : number): void;
		
	/**
	 * 
	 * @param param 
	 * @return  
	 */
	meetsPartyLevelCondition(param : number): boolean;
		
	/**
	 * 
	 * @param param 
	 */
	meetsSwitchCondition(param : number): void;
		
	/**
	 * 
	 * @param action 
	 * @return  
	 */
	isActionValid(action : Game_Action): boolean;
		
	/**
	 * 
	 * @param actionList 
	 * @param ratingZero 
	 * @return  
	 */
    selectAction(actionList: IDataAction[], ratingZero: number):  /* error */ IDataAction;
		
	/**
	 * 
	 * @param actionList 
	 */
	selectAllActions(actionList : IDataAction[]): void;
		
	/**
	 * 
	 */
	makeActions(): void;
		
	/**
	 * 
	 */
	_speed : number;
		
	/**
	 * 
	 */
	_actionState : string;
		
	/**
	 * 
	 */
	_lastTargetIndex : number;
		
	/**
	 * 
	 */
	_damagePopup : boolean;
		
	/**
	 * 
	 */
	_effectType : string;
		
	/**
	 * 
	 */
	_weaponImageId : number;
		
	/**
	 * 
	 */
	_motionRefresh : boolean;
		
	/**
	 * 
	 */
	_selected : boolean;
		
	/**
	 * 
	 */
	_hp : number;
		
	/**
	 * 
	 */
	_mp : number;
		
	/**
	 * 
	 */
	_tp : number;
		
	/**
	 * 
	 */
	_hidden : boolean;
		
	/**
	 * 
	 */
	_enemyId : number;
		
	/**
	 * 
	 */
	_letter : string;
		
	/**
	 * 
	 */
	_plural : boolean;
		
	/**
	 * 
	 */
	_screenX : number;
		
	/**
	 * 
	 */
	_screenY : number;
}

/**
 * -----------------------------------------------------------------------------
 * Game_Actors
 * 
 * The wrapper class for an actor array.
 */
declare interface Game_Actors {
		
	/**
	 * 
	 */
	new ();
		
	/**
	 * 
	 */
	initialize(): void;
		
	/**
	 * 
	 * @param actorId 
	 * @return  
	 */
    actor(actorId: number): /* !this._data.<i> */ Game_Actor;
}

/**
 * -----------------------------------------------------------------------------
 * Game_Unit
 * 
 * The superclass of Game_Party and Game_Troop.
 */
declare interface Game_Unit {
		
	/**
	 * 
	 */
	new ();
		
	/**
	 * 
	 */
	initialize(): void;
		
	/**
	 * 
	 * @return  
	 */
    inBattle(): /* !this._inBattle */ boolean;
		
	/**
	 * 
	 * @return  
	 */
	members(): Game_Unit.prototype.MembersRet;
		
	/**
	 * 
	 * @return  
	 */
	aliveMembers(): Game_Unit.prototype.AliveMembersRet;
		
	/**
	 * 
	 * @return  
	 */
	deadMembers(): Game_Unit.prototype.DeadMembersRet;
		
	/**
	 * 
	 * @return  
	 */
    movableMembers(): Array<Game_Battler>;
		
	/**
	 * 
	 */
	clearActions(): void;
		
	/**
	 * 
	 * @return  
	 */
	agility(): number;
		
	/**
	 * 
	 */
	tgrSum(): void;
		
	/**
	 * 
	 */
	randomTarget(): void;
		
	/**
	 * 
	 */
	randomDeadTarget(): void;
		
	/**
	 * 
	 * @param index 
	 */
	smoothTarget(index : number): void;
		
	/**
	 * 
	 * @param index 
	 */
	smoothDeadTarget(index : number): void;
		
	/**
	 * 
	 */
	clearResults(): void;
		
	/**
	 * 
	 */
	onBattleStart(): void;
		
	/**
	 * 
	 */
	onBattleEnd(): void;
		
	/**
	 * 
	 */
	makeActions(): void;
		
	/**
	 * 
	 * @param activeMember 
	 */
    select(activeMember: Game_Battler): void;
		
	/**
	 * 
	 * @return  
	 */
	isAllDead(): boolean;
		
	/**
	 * 
	 */
	substituteBattler(): void;
}

/**
 * -----------------------------------------------------------------------------
 * Game_Party
 * 
 * The game object class for the party. Information such as gold and items is
 * included.
 */
declare interface Game_Party extends Game_Unit {
		
	/**
	 * 
	 */
	new ();
		
	/**
	 * 
	 */
	initialize(): void;
		
	/**
	 * 
	 */
	initAllItems(): void;
		
	/**
	 * 
	 * @return  
	 */
	exists(): boolean;
		
	/**
	 * 
	 * @return  
	 */
	size(): number;
		
	/**
	 * 
	 * @return  
	 */
	isEmpty(): boolean;
		
	/**
	 * 
	 * @return  
	 */
    members(): Game_Actor[];
		
	/**
	 * 
	 * @return  
	 */
    allMembers(): Game_Actor[];
		
	/**
	 * 
	 * @return  
	 */
    battleMembers(): Game_Actor[];
		
	/**
	 * 
	 * @return  
	 */
	maxBattleMembers(): number;
		
	/**
	 * 
	 */
	leader(): void;
		
	/**
	 * 
	 */
	reviveBattleMembers(): void;
		
	/**
	 * 
	 * @return  
	 */
    items(): Game_Party.prototype.ItemsRet;

	/**
	 * 
	 * @return  
	 */
	weapons(): Game_Party.prototype.WeaponsRet;
		
	/**
	 * 
	 * @return  
	 */
	armors(): Game_Party.prototype.ArmorsRet;
		
	/**
	 * 
	 * @return  
	 */
    equipItems(): Array<IDataEquipItem>;
		
	/**
	 * 
	 * @return  
	 */
    allItems(): Array<IDataAllItem>;
		
	/**
	 * 
	 * @param item 
	 * @return  
	 */
    itemContainer(item: IDataAllItem): /* !this._items */ IDataItem[] | IDataWeapon[] | IDataArmor[];
		
	/**
	 * 
	 */
	setupStartingMembers(): void;
		
	/**
	 * 
	 * @return  
	 */
	name(): string;
		
	/**
	 * 
	 */
	setupBattleTest(): void;
		
	/**
	 * 
	 */
	setupBattleTestMembers(): void;
		
	/**
	 * 
	 */
	setupBattleTestItems(): void;
		
	/**
	 * 
	 * @return  
	 */
	highestLevel(): number;
		
	/**
	 * 
	 * @param actorId 
	 */
	addActor(actorId : number): void;
		
	/**
	 * 
	 * @param actorId 
	 */
	removeActor(actorId : number): void;
		
	/**
	 * 
	 * @return  
	 */
    gold(): /* !this._gold */ number;
		
	/**
	 * 
	 * @param amount 
	 */
	gainGold(amount : number): void;
		
	/**
	 * 
	 * @param amount 
	 */
    loseGold(amount: number): void;
		
	/**
	 * 
	 * @return  
	 */
	maxGold(): number;
		
	/**
	 * 
	 * @return  
	 */
    steps(): /* !this._steps */ number;
		
	/**
	 * 
	 */
	increaseSteps(): void;
		
	/**
	 * 
	 * @param item 
	 * @return  
	 */
	numItems(item : IDataAllItem): number;
		
	/**
	 * 
	 * @param item 
	 * @return  
	 */
	maxItems(item : IDataAllItem): number;
		
	/**
	 * 
	 * @param item 
	 * @return  
	 */
	hasMaxItems(item : IDataAllItem): boolean;
		
	/**
	 * 
	 * @param item 
	 * @param includeEquip 
	 * @return  
	 */
	hasItem(item : IDataAllItem, includeEquip : boolean): boolean;
		
	/**
	 * 
	 * @param item 
	 * @return  
	 */
	isAnyMemberEquipped(item : IDataAllItem): boolean;
		
	/**
	 * 
	 * @param item 
	 * @param amount 
	 * @param includeEquip 
	 */
    gainItem(item: IDataAllItem, amount: number, includeEquip: boolean): void;
		
	/**
	 * 
	 * @param item 
	 * @param amount 
	 */
	discardMembersEquip(item : IDataAllItem, amount : number): void;
		
	/**
	 * 
	 * @param item 
	 * @param amount 
	 * @param includeEquip 
	 */
    loseItem(item: IDataAllItem, amount: number, includeEquip: boolean): void;
		
	/**
	 * 
	 * @param item 
	 */
	consumeItem(item : IDataAllItem): void;
		
	/**
	 * 
	 * @param item 
	 * @return  
	 */
	canUse(item : IDataAllItem): boolean;
		
	/**
	 * 
	 * @return  
	 */
	canInput(): boolean;
		
	/**
	 * 
	 * @return  
	 */
	isAllDead(): boolean;
		
	/**
	 * 
	 */
	onPlayerWalk(): void;
		
	/**
	 * 
	 */
    menuActor(): Game_Actor;
		
	/**
	 * 
	 * @param actor 
	 */
    setMenuActor(actor: Game_Actor): void;
		
	/**
	 * 
	 */
	makeMenuActorNext(): void;
		
	/**
	 * 
	 */
	makeMenuActorPrevious(): void;
		
	/**
	 * 
	 */
    targetActor(): Game_Actor;
		
	/**
	 * 
	 * @param actor 
	 */
    setTargetActor(actor: Game_Actor): void;
		
	/**
	 * 
	 */
	lastItem(): void;
		
	/**
	 * 
	 * @param item 
	 */
	setLastItem(item : IDataAllItem): void;
		
	/**
	 * 
	 * @param index1 
	 * @param index2 
	 */
    swapOrder(index1: number, index2: number): void;
		
	/**
	 * 
	 * @return  
	 */
	charactersForSavefile(): Game_Party.prototype.CharactersForSavefileRet;
		
	/**
	 * 
	 * @return  
	 */
	facesForSavefile(): Game_Party.prototype.FacesForSavefileRet;
		
	/**
	 * 
	 * @param abilityId 
	 * @return  
	 */
	partyAbility(abilityId : number): boolean;
		
	/**
	 * 
	 * @return  
	 */
	hasEncounterHalf(): boolean;
		
	/**
	 * 
	 * @return  
	 */
	hasEncounterNone(): boolean;
		
	/**
	 * 
	 * @return  
	 */
	hasCancelSurprise(): boolean;
		
	/**
	 * 
	 * @return  
	 */
	hasRaisePreemptive(): boolean;
		
	/**
	 * 
	 * @return  
	 */
	hasGoldDouble(): boolean;
		
	/**
	 * 
	 * @return  
	 */
	hasDropItemDouble(): boolean;
		
	/**
	 * 
	 * @param troopAgi 
	 * @return  
	 */
    ratePreemptive(troopAgi: number): number;
		
	/**
	 * 
	 * @param troopAgi 
	 * @return  
	 */
    rateSurprise(troopAgi: number): number;
		
	/**
	 * 
	 */
	performVictory(): void;
		
	/**
	 * 
	 */
	performEscape(): void;
		
	/**
	 * 
	 */
	removeBattleStates(): void;
		
	/**
	 * 
	 */
	requestMotionRefresh(): void;
		
	/**
	 * 
	 */
	ABILITY_ENCOUNTER_HALF : number;
		
	/**
	 * 
	 */
	ABILITY_ENCOUNTER_NONE : number;
		
	/**
	 * 
	 */
	ABILITY_CANCEL_SURPRISE : number;
		
	/**
	 * 
	 */
	ABILITY_RAISE_PREEMPTIVE : number;
		
	/**
	 * 
	 */
	ABILITY_GOLD_DOUBLE : number;
		
	/**
	 * 
	 */
	ABILITY_DROP_ITEM_DOUBLE : number;
}

/**
 * -----------------------------------------------------------------------------
 * Game_Troop
 * 
 * The game object class for a troop and the battle-related data.
 */
declare interface Game_Troop extends Game_Unit {
		
	/**
	 * 
	 */
	new ();
		
	/**
	 * 
	 */
	initialize(): void;
		
	/**
	 * 
	 * @return  
	 */
	isEventRunning(): boolean;
		
	/**
	 * 
	 */
	updateInterpreter(): void;
		
	/**
	 * 
	 * @return  
	 */
    turnCount(): /* !this._turnCount */ number;
		
	/**
	 * 
	 * @return  
	 */
    members(): /* !this._enemies */ Game_Enemy[];
		
	/**
	 * 
	 */
	clear(): void;
		
	/**
	 * 
	 */
	troop(): void;
		
	/**
	 * 
	 * @param troopId 
	 */
	setup(troopId : number): void;
		
	/**
	 * 
	 */
	makeUniqueNames(): void;
		
	/**
	 * 
	 * @return  
	 */
	letterTable(): Array<string>;
		
	/**
	 * 
	 * @return  
	 */
	enemyNames(): Game_Troop.prototype.EnemyNamesRet;
		
	/**
	 * 
	 * @param page 
	 * @return  
	 */
    meetsConditions(page: IDataPage): boolean;
		
	/**
	 * 
	 */
	setupBattleEvent(): void;
		
	/**
	 * 
	 */
	increaseTurn(): void;
		
	/**
	 * 
	 */
	expTotal(): void;
		
	/**
	 * 
	 * @return  
	 */
	goldTotal(): number;
		
	/**
	 * 
	 * @return  
	 */
	goldRate(): number;
		
	/**
	 * 
	 * @return  
	 */
	makeDropItems(): Game_Troop.prototype.MakeDropItemsRet;
		
	/**
	 * 
	 */
	LETTER_TABLE_HALF : Array<string>;
		
	/**
	 * 
	 */
	LETTER_TABLE_FULL : Array<string>;
}

/**
 * -----------------------------------------------------------------------------
 * Game_Map
 * 
 * The game object class for a map. It contains scrolling and passage
 * determination functions.
 */
declare interface Game_Map {
		
	/**
	 * 
	 */
	new ();
		
	/**
	 * 
	 */
	initialize(): void;
		
	/**
	 * 
	 * @param mapId 
	 */
	setup(mapId : number): void;
		
	/**
	 * 
	 * @return  
	 */
	isEventRunning(): boolean;
		
	/**
	 * 
	 * @return  
	 */
	tileWidth(): number;
		
	/**
	 * 
	 * @return  
	 */
	tileHeight(): number;
		
	/**
	 * 
	 * @return  
	 */
    mapId(): /* !this._mapId */ number;
		
	/**
	 * 
	 * @return  
	 */
    tilesetId(): /* !this._tilesetId */ number;
		
	/**
	 * 
	 * @return  
	 */
    displayX(): /* !this._displayX */ number;
		
	/**
	 * 
	 * @return  
	 */
    displayY(): /* !this._displayY */ number;
		
	/**
	 * 
	 * @return  
	 */
    parallaxName(): /* !this._parallaxName */ string;
		
	/**
	 * 
	 * @return  
	 */
    battleback1Name(): /* !this._battleback1Name */ string;
		
	/**
	 * 
	 * @return  
	 */
    battleback2Name(): /* !this._battleback2Name */ string;
		
	/**
	 * 
	 * @param mapId 
	 */
	requestRefresh(mapId : number): void;
		
	/**
	 * 
	 * @return  
	 */
    isNameDisplayEnabled(): /* !this._nameDisplay */ boolean;
		
	/**
	 * 
	 */
	disableNameDisplay(): void;
		
	/**
	 * 
	 */
	enableNameDisplay(): void;
		
	/**
	 * 
	 */
	createVehicles(): void;
		
	/**
	 * 
	 */
	refereshVehicles(): void;
		
	/**
	 * 
	 * @return  
	 */
	vehicles(): Game_Map.prototype.VehiclesRet;
		
	/**
	 * 
	 * @param type 
	 * @return  
	 */
    vehicle(type: string): /* Game_Map.prototype.+Game_Vehicle */ Game_Vehicle;
		
	/**
	 * 
	 * @return  
	 */
    boat(): /* !this._vehicles.0 */ Game_Vehicle;
		
	/**
	 * 
	 * @return  
	 */
    ship(): /* !this._vehicles.1 */ Game_Vehicle;
		
	/**
	 * 
	 * @return  
	 */
    airship(): /* !this._vehicles.2 */ Game_Vehicle;
		
	/**
	 * 
	 */
	setupEvents(): void;
		
	/**
	 * 
	 * @return  
	 */
	events(): Game_Map.prototype.EventsRet;
		
	/**
	 * 
	 * @param eventId 
	 * @return  
	 */
    event(eventId: number): /* Game_Map.prototype.+Game_Event */ Game_Event;
		
	/**
	 * 
	 * @param eventId 
	 */
	eraseEvent(eventId : number): void;
		
	/**
	 * 
	 */
	parallelCommonEvents(): void;
		
	/**
	 * 
	 */
	setupScroll(): void;
		
	/**
	 * 
	 */
	setupParallax(): void;
		
	/**
	 * 
	 */
	setupBattleback(): void;
		
	/**
	 * 
	 * @param x 
	 * @param y 
	 */
	setDisplayPos(x : number, y : number): void;
		
	/**
	 * 
	 * @return  
	 */
	parallaxOx(): number;
		
	/**
	 * 
	 * @return  
	 */
	parallaxOy(): number;
		
	/**
	 * 
	 */
	tileset(): void;
		
	/**
	 * 
	 * @return  
	 */
	tilesetFlags(): Game_Map.prototype.TilesetFlagsRet;
		
	/**
	 * 
	 */
	displayName(): void;
		
	/**
	 * 
	 */
	width(): void;
		
	/**
	 * 
	 */
	height(): void;
		
	/**
	 * 
	 */
	data(): void;
		
	/**
	 * 
	 * @return  
	 */
	isLoopHorizontal(): boolean;
		
	/**
	 * 
	 * @return  
	 */
	isLoopVertical(): boolean;
		
	/**
	 * 
	 */
	isDashDisabled(): void;
		
	/**
	 * 
	 */
	encounterList(): void;
		
	/**
	 * 
	 */
	encounterStep(): void;
		
	/**
	 * 
	 * @return  
	 */
	isOverworld(): boolean;
		
	/**
	 * 
	 * @return  
	 */
	screenTileX(): number;
		
	/**
	 * 
	 * @return  
	 */
	screenTileY(): number;
		
	/**
	 * 
	 * @param x 
	 * @return  
	 */
	adjustX(x : number): number;
		
	/**
	 * 
	 * @param y 
	 * @return  
	 */
	adjustY(y : number): number;
		
	/**
	 * 
	 * @param x 
	 * @return  
	 */
	roundX(x : number): number;
		
	/**
	 * 
	 * @param y 
	 * @return  
	 */
	roundY(y : number): number;
		
	/**
	 * 
	 * @param x 
	 * @param d 
	 */
	xWithDirection(x : number, d : number): void;
		
	/**
	 * 
	 * @param y 
	 * @param d 
	 */
	yWithDirection(y : number, d : number): void;
		
	/**
	 * 
	 * @param x 
	 * @param d 
	 */
	roundXWithDirection(x : number, d : number): void;
		
	/**
	 * 
	 * @param y 
	 * @param d 
	 */
	roundYWithDirection(y : number, d : number): void;
		
	/**
	 * 
	 * @param x1 
	 * @param x2 
	 * @return  
	 */
	deltaX(x1 : number, x2 : number): number;
		
	/**
	 * 
	 * @param y1 
	 * @param y2 
	 * @return  
	 */
	deltaY(y1 : number, y2 : number): number;
		
	/**
	 * 
	 * @param x1 
	 * @param y1 
	 * @param x2 
	 * @param y2 
	 * @return  
	 */
	distance(x1 : number, y1 : number, x2 : number, y2 : number): number;
		
	/**
	 * 
	 * @param x 
	 * @return  
	 */
	canvasToMapX(x : Game_Map.prototype.CanvasToMapX0): number;
		
	/**
	 * 
	 * @param y 
	 * @return  
	 */
	canvasToMapY(y : Game_Map.prototype.CanvasToMapY0): number;
		
	/**
	 * 
	 */
	autoplay(): void;
		
	/**
	 * 
	 */
	refreshIfNeeded(): void;
		
	/**
	 * 
	 */
	refresh(): void;
		
	/**
	 * 
	 */
	refreshTileEvents(): void;
		
	/**
	 * 
	 * @param x 
	 * @param y 
	 * @return  
	 */
	eventsXy(x : number, y : number): Array<Game_Event>;
		
	/**
	 * 
	 * @param x 
	 * @param y 
	 * @return  
	 */
	eventsXyNt(x : number, y : number): Array<Game_Event>;
		
	/**
	 * 
	 * @param x 
	 * @param y 
	 * @return  
	 */
	tileEventsXy(x : number, y : number): Array<Game_Event>;
		
	/**
	 * 
	 * @param x 
	 * @param y 
	 * @return  
	 */
	eventIdXy(x : number, y : number): number;
		
	/**
	 * 
	 * @param distance 
	 */
	scrollDown(distance : number): void;
		
	/**
	 * 
	 * @param distance 
	 */
	scrollLeft(distance : number): void;
		
	/**
	 * 
	 * @param distance 
	 */
	scrollRight(distance : number): void;
		
	/**
	 * 
	 * @param distance 
	 */
	scrollUp(distance : number): void;
		
	/**
	 * 
	 * @param x 
	 * @param y 
	 * @return  
	 */
	isValid(x : number, y : number): boolean;
		
	/**
	 * 
	 * @param x 
	 * @param y 
	 * @param bit 
	 * @return  
	 */
	checkPassage(x : number, y : number, bit : number): boolean;
		
	/**
	 * 
	 * @param x 
	 * @param y 
	 * @param z 
	 * @return  
	 */
	tileId(x : number, y : number, z : number): number;
		
	/**
	 * 
	 * @param x 
	 * @param y 
	 * @return  
	 */
	layeredTiles(x : number, y : number): Game_Map.prototype.LayeredTilesRet;
		
	/**
	 * 
	 * @param x 
	 * @param y 
	 * @return  
	 */
	allTiles(x : number, y : number): Game_Map.prototype.AllTilesRet;
		
	/**
	 * 
	 * @param x 
	 * @param y 
	 * @param z 
	 * @return  
	 */
	autotileType(x : number, y : number, z : number): number;
		
	/**
	 * 
	 * @param x 
	 * @param y 
	 * @param d 
	 * @return  
	 */
	isPassable(x : number, y : number, d : number): boolean;
		
	/**
	 * 
	 * @param x 
	 * @param y 
	 * @return  
	 */
	isBoatPassable(x : number, y : number): boolean;
		
	/**
	 * 
	 * @param x 
	 * @param y 
	 * @return  
	 */
	isShipPassable(x : number, y : number): boolean;
		
	/**
	 * 
	 * @param x 
	 * @param y 
	 * @return  
	 */
	isAirshipLandOk(x : number, y : number): boolean;
		
	/**
	 * 
	 * @param x 
	 * @param y 
	 * @param bit 
	 * @return  
	 */
	checkLayeredTilesFlags(x : number, y : number, bit : number): boolean;
		
	/**
	 * 
	 * @param x 
	 * @param y 
	 * @return  
	 */
	isLadder(x : number, y : number): boolean;
		
	/**
	 * 
	 * @param x 
	 * @param y 
	 * @return  
	 */
	isBush(x : number, y : number): boolean;
		
	/**
	 * 
	 * @param x 
	 * @param y 
	 * @return  
	 */
	isCounter(x : number, y : number): boolean;
		
	/**
	 * 
	 * @param x 
	 * @param y 
	 * @return  
	 */
	isDamageFloor(x : number, y : number): boolean;
		
	/**
	 * 
	 * @param x 
	 * @param y 
	 * @return  
	 */
	terrainTag(x : number, y : number): number;
		
	/**
	 * 
	 * @param x 
	 * @param y 
	 * @return  
	 */
	regionId(x : number, y : number): number;
		
	/**
	 * 
	 * @param direction 
	 * @param distance 
	 * @param speed 
	 */
	startScroll(direction : number, distance : number, speed : number): void;
		
	/**
	 * 
	 * @return  
	 */
	isScrolling(): boolean;
		
	/**
	 * 
	 * @param sceneActive 
	 */
    update(sceneActive: boolean): void;
		
	/**
	 * 
	 */
	updateScroll(): void;
		
	/**
	 * 
	 * @return  
	 */
	scrollDistance(): number;
		
	/**
	 * 
	 * @param direction 
	 * @param distance 
	 */
	doScroll(direction : number, distance : number): void;
		
	/**
	 * 
	 */
	updateEvents(): void;
		
	/**
	 * 
	 */
	updateVehicles(): void;
		
	/**
	 * 
	 */
	updateParallax(): void;
		
	/**
	 * 
	 * @param tilesetId 
	 */
	changeTileset(tilesetId : number): void;
		
	/**
	 * 
	 * @param battleback1Name 
	 * @param battleback2Name 
	 */
	changeBattleback(battleback1name : string, battleback2name : string): void;
		
	/**
	 * 
	 * @param name 
	 * @param loopX 
	 * @param loopY 
	 * @param sx 
	 * @param sy 
	 */
	changeParallax(name : string, loopx : number, loopy : number, sx : number, sy : number): void;
		
	/**
	 * 
	 */
	updateInterpreter(): void;
		
	/**
	 * 
	 * @param eventId 
	 */
	unlockEvent(eventId : number): void;
		
	/**
	 * 
	 * @return  
	 */
	setupStartingEvent(): boolean;
		
	/**
	 * 
	 * @return  
	 */
	setupTestEvent(): boolean;
		
	/**
	 * 
	 * @return  
	 */
	setupStartingMapEvent(): boolean;
		
	/**
	 * 
	 * @return  
	 */
	setupAutorunCommonEvent(): boolean;
		
	/**
	 * 
	 * @return  
	 */
	isAnyEventStarting(): boolean;
}

/**
 * -----------------------------------------------------------------------------
 * Game_CommonEvent
 * 
 * The game object class for a common event. It contains functionality for
 * running parallel process events.
 */
declare interface Game_CommonEvent {
		
	/**
	 * 
	 */
	new ();
		
	/**
	 * 
	 * @param commonEventId 
	 */
	initialize(commonEventId : number): void;
		
	/**
	 * 
	 */
	event(): void;
		
	/**
	 * 
	 */
	list(): void;
		
	/**
	 * 
	 */
	refresh(): void;
		
	/**
	 * 
	 * @return  
	 */
	isActive(): boolean;
		
	/**
	 * 
	 */
	update(): void;
}

/**
 * -----------------------------------------------------------------------------
 * Game_CharacterBase
 * 
 * The superclass of Game_Character. It handles basic information, such as
 * coordinates and images, shared by all characters.
 */
declare interface Game_CharacterBase {
		
	/**
	 * 
	 */
	new ();
		
	/**
	 * 
	 */
	//TODO:initialize(): void;
		
	/**
	 * 
	 */
	initMembers(): void;
		
	/**
	 * 
	 * @param x 
	 * @param y 
	 * @return  
	 */
	pos(x : number, y : number): boolean;
		
	/**
	 * 
	 * @param x 
	 * @param y 
	 * @return  
	 */
	posNt(x : number, y : number): boolean;
		
	/**
	 * 
	 * @return  
	 */
    moveSpeed(): /* !this._moveSpeed */ number;
		
	/**
	 * 
	 * @param moveSpeed 
	 */
	setMoveSpeed(moveSpeed : number): void;
		
	/**
	 * 
	 * @return  
	 */
    moveFrequency(): /* !this._moveFrequency */ number;
		
	/**
	 * 
	 * @param moveFrequency 
	 */
	setMoveFrequency(moveFrequency : number): void;
		
	/**
	 * 
	 * @return  
	 */
    opacity(): /* !this._opacity */ number;
		
	/**
	 * 
	 * @param opacity 
	 */
	setOpacity(opacity : number): void;
		
	/**
	 * 
	 * @return  
	 */
    blendMode(): /* !this._blendMode */ number;
		
	/**
	 * 
	 * @param blendMode 
	 */
    setBlendMode(blendMode: number): void;
		
	/**
	 * 
	 * @return  
	 */
	isNormalPriority(): boolean;
		
	/**
	 * 
	 * @param priorityType 
	 */
	setPriorityType(priorityType : number): void;
		
	/**
	 * 
	 * @return  
	 */
	isMoving(): boolean;
		
	/**
	 * 
	 * @return  
	 */
	isJumping(): boolean;
		
	/**
	 * 
	 * @return  
	 */
	jumpHeight(): number;
		
	/**
	 * 
	 * @return  
	 */
	isStopping(): boolean;
		
	/**
	 * 
	 * @param threshold 
	 * @return  
	 */
	checkStop(threshold : number): boolean;
		
	/**
	 * 
	 */
	resetStopCount(): void;
		
	/**
	 * 
	 * @return  
	 */
	realMoveSpeed(): number;
		
	/**
	 * 
	 * @return  
	 */
	distancePerFrame(): number;
		
	/**
	 * 
	 * @return  
	 */
	isDashing(): boolean;
		
	/**
	 * 
	 * @return  
	 */
	isDebugThrough(): boolean;
		
	/**
	 * 
	 */
	straighten(): void;
		
	/**
	 * 
	 * @param d 
	 * @return  
	 */
	reverseDir(d : number): number;
		
	/**
	 * 
	 * @param x 
	 * @param y 
	 * @param d 
	 * @return  
	 */
	canPass(x : number, y : number, d : number): boolean;
		
	/**
	 * 
	 * @param x 
	 * @param y 
	 * @param horz 
	 * @param vert 
	 * @return  
	 */
	canPassDiagonally(x : number, y : number, horz : number, vert : number): boolean;
		
	/**
	 * 
	 * @param x 
	 * @param y 
	 * @param d 
	 */
	isMapPassable(x : number, y : number, d : number): void;
		
	/**
	 * 
	 * @param x 
	 * @param y 
	 */
	isCollidedWithCharacters(x : number, y : number): void;
		
	/**
	 * 
	 * @param x 
	 * @param y 
	 */
	isCollidedWithEvents(x : number, y : number): void;
		
	/**
	 * 
	 * @param x 
	 * @param y 
	 */
	isCollidedWithVehicles(x : number, y : number): void;
		
	/**
	 * 
	 * @param x 
	 * @param y 
	 */
	setPosition(x : number, y : number): void;
		
	/**
	 * 
	 * @param character 
	 */
    copyPosition(character: Game_CharacterBase): void;
		
	/**
	 * 
	 * @param x 
	 * @param y 
	 */
	locate(x : number, y : number): void;
		
	/**
	 * 
	 * @return  
	 */
    direction(): /* !this._direction */ number;
		
	/**
	 * 
	 * @param d 
	 */
	setDirection(d : number): void;
		
	/**
	 * 
	 * @return  
	 */
	isTile(): boolean;
		
	/**
	 * 
	 * @return  
	 */
    isObjectCharacter(): /* !this._isObjectCharacter */ boolean;
		
	/**
	 * 
	 * @return  
	 */
	shiftY(): number;
		
	/**
	 * 
	 */
	scrolledX(): void;
		
	/**
	 * 
	 */
	scrolledY(): void;
		
	/**
	 * 
	 * @return  
	 */
	screenX(): number;
		
	/**
	 * 
	 * @return  
	 */
	screenY(): number;
		
	/**
	 * 
	 * @return  
	 */
	screenZ(): number;
		
	/**
	 * 
	 * @return  
	 */
	isNearTheScreen(): boolean;
		
	/**
	 * 
	 */
	//TODO:update(): void;
		
	/**
	 * 
	 */
	updateStop(): void;
		
	/**
	 * 
	 */
	updateJump(): void;
		
	/**
	 * 
	 */
	updateMove(): void;
		
	/**
	 * 
	 */
	updateAnimation(): void;
		
	/**
	 * 
	 * @return  
	 */
	animationWait(): number;
		
	/**
	 * 
	 */
	updateAnimationCount(): void;
		
	/**
	 * 
	 */
	updatePattern(): void;
		
	/**
	 * 
	 * @return  
	 */
	maxPattern(): number;
		
	/**
	 * 
	 * @return  
	 */
    pattern(): /* !this._pattern */ number;
		
	/**
	 * 
	 * @param pattern 
	 */
	setPattern(pattern : number): void;
		
	/**
	 * 
	 * @return  
	 */
	isOriginalPattern(): boolean;
		
	/**
	 * 
	 */
	resetPattern(): void;
		
	/**
	 * 
	 */
	refreshBushDepth(): void;
		
	/**
	 * 
	 */
	isOnLadder(): void;
		
	/**
	 * 
	 */
	isOnBush(): void;
		
	/**
	 * 
	 */
	terrainTag(): void;
		
	/**
	 * 
	 */
	regionId(): void;
		
	/**
	 * 
	 */
	increaseSteps(): void;
		
	/**
	 * 
	 * @return  
	 */
    tileId(): /* !this._tileId */ number;
		
	/**
	 * 
	 * @return  
	 */
    characterName(): /* !this._characterName */ string;
		
	/**
	 * 
	 * @return  
	 */
    characterIndex(): /* !this._characterIndex */ number;
		
	/**
	 * 
	 * @param characterName 
	 * @param characterIndex 
	 */
	setImage(characterName : string, characterIndex : number): void;
		
	/**
	 * 
	 * @param tileId 
	 */
	setTileImage(tileId : number): void;
		
	/**
	 * 
	 * @param d 
	 */
	checkEventTriggerTouchFront(d : number): void;
		
	/**
	 * 
	 * @param x 
	 * @param y 
	 * @return  
	 */
	//TODO:checkEventTriggerTouch(x : number, y : number): boolean;
		
	/**
	 * 
	 * @param x 
	 * @param y 
	 * @return  
	 */
    isMovementSucceeded(x: number, y: number): /* !this._movementSuccess */ boolean;
		
	/**
	 * 
	 * @param success 
	 */
	setMovementSuccess(success : boolean): void;
		
	/**
	 * 
	 * @param d 
	 */
	moveStraight(d : number): void;
		
	/**
	 * 
	 * @param horz 
	 * @param vert 
	 */
	moveDiagonally(horz : number, vert : number): void;
		
	/**
	 * 
	 * @param xPlus 
	 * @param yPlus 
	 */
    jump(xPlus: number, yPlus: number): void;
		
	/**
	 * 
	 * @return  
	 */
    hasWalkAnime(): /* !this._walkAnime */ boolean;
		
	/**
	 * 
	 * @param walkAnime 
	 */
	setWalkAnime(walkAnime : boolean): void;
		
	/**
	 * 
	 * @return  
	 */
    hasStepAnime(): /* !this._stepAnime */ boolean;
		
	/**
	 * 
	 * @param stepAnime 
	 */
	setStepAnime(stepAnime : boolean): void;
		
	/**
	 * 
	 * @return  
	 */
    isDirectionFixed(): /* !this._directionFix */ boolean;
		
	/**
	 * 
	 * @param directionFix 
	 */
	setDirectionFix(directionFix : boolean): void;
		
	/**
	 * 
	 * @return  
	 */
    isThrough(): /* !this._through */ boolean;
		
	/**
	 * 
	 * @param through 
	 */
	setThrough(through : boolean): void;
		
	/**
	 * 
	 * @return  
	 */
    isTransparent(): /* !this._transparent */ boolean;
		
	/**
	 * 
	 * @return  
	 */
    bushDepth(): /* !this._bushDepth */ number;
		
	/**
	 * 
	 * @param transparent 
	 */
	setTransparent(transparent : boolean): void;
		
	/**
	 * 
	 * @param animationId 
	 */
	requestAnimation(animationId : number): void;
		
	/**
	 * 
	 * @param balloonId 
	 */
	requestBalloon(balloonId : number): void;
		
	/**
	 * 
	 * @return  
	 */
    animationId(): /* !this._animationId */ number;
		
	/**
	 * 
	 * @return  
	 */
    balloonId(): /* !this._balloonId */ number;
		
	/**
	 * 
	 */
	startAnimation(): void;
		
	/**
	 * 
	 */
	startBalloon(): void;
		
	/**
	 * 
	 * @return  
	 */
    isAnimationPlaying(): /* !this._animationPlaying */ boolean;
		
	/**
	 * 
	 * @return  
	 */
    isBalloonPlaying(): /* !this._balloonPlaying */ boolean;
		
	/**
	 * 
	 */
	endAnimation(): void;
		
	/**
	 * 
	 */
	endBalloon(): void;
}

/**
 * -----------------------------------------------------------------------------
 * Game_Character
 * 
 * The superclass of Game_Player, Game_Follower, GameVehicle, and Game_Event.
 */
declare interface Game_Character extends Game_CharacterBase {
		
	/**
	 * 
	 */
	new ();
		
	/**
	 * 
	 */
	//TODO:initialize(): void;
		
	/**
	 * 
	 */
	initMembers(): void;
		
	/**
	 * 
	 */
	memorizeMoveRoute(): void;
		
	/**
	 * 
	 */
	restoreMoveRoute(): void;
		
	/**
	 * 
	 * @return  
	 */
    isMoveRouteForcing(): /* !this._moveRouteForcing */ boolean;
		
	/**
	 * 
	 * @param moveRoute 
	 */
    setMoveRoute(moveRoute: IDataMoveRoute): void;
		
	/**
	 * 
	 * @param moveRoute 
	 */
    forceMoveRoute(moveRoute: IDataMoveRoute): void;
		
	/**
	 * 
	 */
	updateStop(): void;
		
	/**
	 * 
	 */
	updateRoutineMove(): void;
		
	/**
	 * 
	 * @param command 
	 */
	processMoveCommand(command : number): void;
		
	/**
	 * 
	 * @param x 
	 */
	deltaXFrom(x : number): void;
		
	/**
	 * 
	 * @param y 
	 */
	deltaYFrom(y : number): void;
		
	/**
	 * 
	 */
	moveRandom(): void;
		
	/**
	 * 
	 * @param character 
	 */
	moveTowardCharacter(character : Game_Character.prototype.MoveTowardCharacter0): void;
		
	/**
	 * 
	 * @param character 
	 */
    moveAwayFromCharacter(character: Game_CharacterBase): void;
		
	/**
	 * 
	 * @param character 
	 */
    turnTowardCharacter(character: Game_CharacterBase): void;
		
	/**
	 * 
	 * @param character 
	 */
    turnAwayFromCharacter(character: Game_CharacterBase): void;
		
	/**
	 * 
	 */
	turnTowardPlayer(): void;
		
	/**
	 * 
	 */
	turnAwayFromPlayer(): void;
		
	/**
	 * 
	 */
	moveTowardPlayer(): void;
		
	/**
	 * 
	 */
	moveAwayFromPlayer(): void;
		
	/**
	 * 
	 */
	moveForward(): void;
		
	/**
	 * 
	 */
	moveBackward(): void;
		
	/**
	 * 
	 */
	processRouteEnd(): void;
		
	/**
	 * 
	 */
	advanceMoveRouteIndex(): void;
		
	/**
	 * 
	 */
	turnRight90(): void;
		
	/**
	 * 
	 */
	turnLeft90(): void;
		
	/**
	 * 
	 */
	turn180(): void;
		
	/**
	 * 
	 */
	turnRightOrLeft90(): void;
		
	/**
	 * 
	 */
	turnRandom(): void;
		
	/**
	 * 
	 * @param character 
	 */
    swap(character: Game_CharacterBase): void;
		
	/**
	 * 
	 * @param goalX 
	 * @param goalY 
	 * @return  
	 */
	findDirectionTo(goalx : number, goaly : number): number;
		
	/**
	 * 
	 * @return  
	 */
	searchLimit(): number;
		
	/**
	 * 
	 */
	ROUTE_END : number;
		
	/**
	 * 
	 */
	ROUTE_MOVE_DOWN : number;
		
	/**
	 * 
	 */
	ROUTE_MOVE_LEFT : number;
		
	/**
	 * 
	 */
	ROUTE_MOVE_RIGHT : number;
		
	/**
	 * 
	 */
	ROUTE_MOVE_UP : number;
		
	/**
	 * 
	 */
	ROUTE_MOVE_LOWER_L : number;
		
	/**
	 * 
	 */
	ROUTE_MOVE_LOWER_R : number;
		
	/**
	 * 
	 */
	ROUTE_MOVE_UPPER_L : number;
		
	/**
	 * 
	 */
	ROUTE_MOVE_UPPER_R : number;
		
	/**
	 * 
	 */
	ROUTE_MOVE_RANDOM : number;
		
	/**
	 * 
	 */
	ROUTE_MOVE_TOWARD : number;
		
	/**
	 * 
	 */
	ROUTE_MOVE_AWAY : number;
		
	/**
	 * 
	 */
	ROUTE_MOVE_FORWARD : number;
		
	/**
	 * 
	 */
	ROUTE_MOVE_BACKWARD : number;
		
	/**
	 * 
	 */
	ROUTE_JUMP : number;
		
	/**
	 * 
	 */
	ROUTE_WAIT : number;
		
	/**
	 * 
	 */
	ROUTE_TURN_DOWN : number;
		
	/**
	 * 
	 */
	ROUTE_TURN_LEFT : number;
		
	/**
	 * 
	 */
	ROUTE_TURN_RIGHT : number;
		
	/**
	 * 
	 */
	ROUTE_TURN_UP : number;
		
	/**
	 * 
	 */
	ROUTE_TURN_90D_R : number;
		
	/**
	 * 
	 */
	ROUTE_TURN_90D_L : number;
		
	/**
	 * 
	 */
	ROUTE_TURN_180D : number;
		
	/**
	 * 
	 */
	ROUTE_TURN_90D_R_L : number;
		
	/**
	 * 
	 */
	ROUTE_TURN_RANDOM : number;
		
	/**
	 * 
	 */
	ROUTE_TURN_TOWARD : number;
		
	/**
	 * 
	 */
	ROUTE_TURN_AWAY : number;
		
	/**
	 * 
	 */
	ROUTE_SWITCH_ON : number;
		
	/**
	 * 
	 */
	ROUTE_SWITCH_OFF : number;
		
	/**
	 * 
	 */
	ROUTE_CHANGE_SPEED : number;
		
	/**
	 * 
	 */
	ROUTE_CHANGE_FREQ : number;
		
	/**
	 * 
	 */
	ROUTE_WALK_ANIME_ON : number;
		
	/**
	 * 
	 */
	ROUTE_WALK_ANIME_OFF : number;
		
	/**
	 * 
	 */
	ROUTE_STEP_ANIME_ON : number;
		
	/**
	 * 
	 */
	ROUTE_STEP_ANIME_OFF : number;
		
	/**
	 * 
	 */
	ROUTE_DIR_FIX_ON : number;
		
	/**
	 * 
	 */
	ROUTE_DIR_FIX_OFF : number;
		
	/**
	 * 
	 */
	ROUTE_THROUGH_ON : number;
		
	/**
	 * 
	 */
	ROUTE_THROUGH_OFF : number;
		
	/**
	 * 
	 */
	ROUTE_TRANSPARENT_ON : number;
		
	/**
	 * 
	 */
	ROUTE_TRANSPARENT_OFF : number;
		
	/**
	 * 
	 */
	ROUTE_CHANGE_IMAGE : number;
		
	/**
	 * 
	 */
	ROUTE_CHANGE_OPACITY : number;
		
	/**
	 * 
	 */
	ROUTE_CHANGE_BLEND_MODE : number;
		
	/**
	 * 
	 */
	ROUTE_PLAY_SE : number;
		
	/**
	 * 
	 */
	ROUTE_SCRIPT : number;
}

/**
 * -----------------------------------------------------------------------------
 * Game_Player
 * 
 * The game object class for the player. It contains event starting
 * determinants and map scrolling functions.
 */
declare interface Game_Player extends Game_Character {
		
	/**
	 * 
	 */
	new ();
		
	/**
	 * 
	 */
	initialize(): void;
		
	/**
	 * 
	 */
	initMembers(): void;
		
	/**
	 * 
	 */
	clearTransferInfo(): void;
		
	/**
	 * 
	 * @return  
	 */
    followers(): /* !this._followers */ Game_Followers;
		
	/**
	 * 
	 */
	refresh(): void;
		
	/**
	 * 
	 * @return  
	 */
	isStopping(): boolean;
		
	/**
	 * 
	 * @param mapId 
	 * @param x 
	 * @param y 
	 * @param d 
	 * @param fadeType 
	 */
    reserveTransfer(mapId: number, x: number, y: number, d: number, fadeType: number): void;
		
	/**
	 * 
	 */
	requestMapReload(): void;
		
	/**
	 * 
	 * @return  
	 */
    isTransferring(): /* !this._transferring */ boolean;
		
	/**
	 * 
	 * @return  
	 */
    newMapId(): /* !this._newMapId */ number;
		
	/**
	 * 
	 * @return  
	 */
    fadeType(): /* !this._fadeType */ number;
		
	/**
	 * 
	 */
	performTransfer(): void;
		
	/**
	 * 
	 * @param x 
	 * @param y 
	 * @param d 
	 */
	isMapPassable(x : number, y : number, d : number): void;
		
	/**
	 * 
	 */
	vehicle(): void;
		
	/**
	 * 
	 * @return  
	 */
	isInBoat(): boolean;
		
	/**
	 * 
	 * @return  
	 */
	isInShip(): boolean;
		
	/**
	 * 
	 * @return  
	 */
	isInAirship(): boolean;
		
	/**
	 * 
	 * @return  
	 */
	isInVehicle(): boolean;
		
	/**
	 * 
	 * @return  
	 */
	isNormal(): boolean;
		
	/**
	 * 
	 * @return  
	 */
    isDashing(): /* !this._dashing */ boolean;
		
	/**
	 * 
	 */
    isDebugThrough(): boolean;
		
	/**
	 * 
	 * @param x 
	 * @param y 
	 * @return  
	 */
	isCollided(x : number, y : number): boolean;
		
	/**
	 * 
	 * @return  
	 */
	centerX(): number;
		
	/**
	 * 
	 * @return  
	 */
	centerY(): number;
		
	/**
	 * 
	 * @param x 
	 * @param y 
	 */
	center(x : number, y : number): void;
		
	/**
	 * 
	 * @param x 
	 * @param y 
	 */
	locate(x : number, y : number): void;
		
	/**
	 * 
	 */
	increaseSteps(): void;
		
	/**
	 * 
	 */
	makeEncounterCount(): void;
		
	/**
	 * 
	 * @return  
	 */
	makeEncounterTroopId(): number;
		
	/**
	 * 
	 * @param encounter 
	 * @return  
	 */
    meetsEncounterConditions(encounter: IDataEncounterList): boolean;
		
	/**
	 * 
	 * @return  
	 */
	executeEncounter(): boolean;
		
	/**
	 * 
	 * @param x 
	 * @param y 
	 * @param triggers 
	 * @param normal 
	 */
	startMapEvent(x : number, y : number, triggers : Game_Player.prototype.StartMapEvent2, normal : boolean): void;
		
	/**
	 * 
	 */
	moveByInput(): void;
		
	/**
	 * 
	 * @return  
	 */
	canMove(): boolean;
		
	/**
	 * 
	 */
	getInputDirection(): void;
		
	/**
	 * 
	 * @param direction 
	 */
	executeMove(direction : number): void;
		
	/**
	 * 
	 * @param sceneActive 
	 */
    update(sceneActive: boolean): void;
		
	/**
	 * 
	 */
	updateDashing(): void;
		
	/**
	 * 
	 * @return  
	 */
	isDashButtonPressed(): boolean;
		
	/**
	 * 
	 * @param lastScrolledX 
	 * @param lastScrolledY 
	 */
	updateScroll(lastScrolledx : number, lastScrolledy : number): void;
		
	/**
	 * 
	 */
	updateVehicle(): void;
		
	/**
	 * 
	 */
	updateVehicleGetOn(): void;
		
	/**
	 * 
	 */
	updateVehicleGetOff(): void;
		
	/**
	 * 
	 * @param wasMoving 
	 */
	updateNonmoving(wasMoving : boolean): void;
		
	/**
	 * 
	 * @return  
	 */
	triggerAction(): boolean;
		
	/**
	 * 
	 * @return  
	 */
	triggerButtonAction(): boolean;
		
	/**
	 * 
	 * @return  
	 */
	triggerTouchAction(): boolean;
		
	/**
	 * 
	 * @param x1 
	 * @param y1 
	 * @return  
	 */
	triggerTouchActionD1(x1 : number, y1 : number): boolean;
		
	/**
	 * 
	 * @param x2 
	 * @param y2 
	 * @return  
	 */
	triggerTouchActionD2(x2 : number, y2 : number): boolean;
		
	/**
	 * 
	 * @param x2 
	 * @param y2 
	 */
	triggerTouchActionD3(x2 : number, y2 : number): void;
		
	/**
	 * 
	 */
	updateEncounterCount(): void;
		
	/**
	 * 
	 * @return  
	 */
	canEncounter(): boolean;
		
	/**
	 * 
	 * @return  
	 */
	encounterProgressValue(): number;
		
	/**
	 * 
	 * @param triggers 
	 */
	checkEventTriggerHere(triggers : Game_Player.prototype.CheckEventTriggerHere0): void;
		
	/**
	 * 
	 * @param triggers 
	 */
	checkEventTriggerThere(triggers : Game_Player.prototype.CheckEventTriggerThere0): void;
		
	/**
	 * 
	 * @param x 
	 * @param y 
	 */
	checkEventTriggerTouch(x : number, y : number): void;
		
	/**
	 * 
	 * @return  
	 */
	canStartLocalEvents(): boolean;
		
	/**
	 * 
	 * @return  
	 */
	getOnOffVehicle(): boolean;
		
	/**
	 * 
	 * @return  
	 */
    getOnVehicle(): /* !this._vehicleGettingOn */ boolean;
		
	/**
	 * 
	 * @return  
	 */
    getOffVehicle(): /* !this._vehicleGettingOff */ boolean;
		
	/**
	 * 
	 */
	forceMoveForward(): void;
		
	/**
	 * 
	 * @return  
	 */
	isOnDamageFloor(): boolean;
		
	/**
	 * 
	 * @param d 
	 */
	moveStraight(d : number): void;
		
	/**
	 * 
	 * @param horz 
	 * @param vert 
	 */
    moveDiagonally(horz: number, vert: null): void;
		
	/**
	 * 
	 * @param xPlus 
	 * @param yPlus 
	 */
    jump(xPlus: number, yPlus: number): void;
		
	/**
	 * 
	 */
	showFollowers(): void;
		
	/**
	 * 
	 */
	hideFollowers(): void;
		
	/**
	 * 
	 */
	gatherFollowers(): void;
		
	/**
	 * 
	 * @return  
	 */
	areFollowersGathering(): boolean;
		
	/**
	 * 
	 * @return  
	 */
	areFollowersGathered(): boolean;
}

/**
 * -----------------------------------------------------------------------------
 * Game_Follower
 * 
 * The game object class for a follower. A follower is an allied character,
 * other than the front character, displayed in the party.
 */
declare interface Game_Follower extends Game_Character {
		
	/**
	 * 
	 */
	new ();
		
	/**
	 * 
	 * @param memberIndex 
	 */
	initialize(memberIndex : number): void;
    //TODO: constructor(memberIndex: any): void;

	/**
	 * 
	 */
	refresh(): void;
		
	/**
	 * 
	 */
	actor(): void;
		
	/**
	 * 
	 */
	isVisible(): void;
		
	/**
	 * 
	 */
	update(): void;
		
	/**
	 * 
	 * @param character 
	 */
	chaseCharacter(character : Game_Follower): void;
		
	/**
	 * 
	 */
	_moveRouteForcing : boolean;
		
	/**
	 * 
	 */
	_moveRouteIndex : number;
		
	/**
	 * 
	 */
	_originalMoveRouteIndex : number;
		
	/**
	 * 
	 */
	_waitCount : number;
		
	/**
	 * 
	 */
	_x : number;
		
	/**
	 * 
	 */
	_y : number;
		
	/**
	 * 
	 */
	_realX : number;
		
	/**
	 * 
	 */
	_realY : number;
		
	/**
	 * 
	 */
	_moveSpeed : number;
		
	/**
	 * 
	 */
	_moveFrequency : number;
		
	/**
	 * 
	 */
	_opacity : number;
		
	/**
	 * 
	 */
	_blendMode : number;
		
	/**
	 * 
	 */
	_direction : number;
		
	/**
	 * 
	 */
	_pattern : number;
		
	/**
	 * 
	 */
	_priorityType : number;
		
	/**
	 * 
	 */
	_tileId : number;
		
	/**
	 * 
	 */
	_characterName : string;
		
	/**
	 * 
	 */
	_characterIndex : number;
		
	/**
	 * 
	 */
	_isObjectCharacter : boolean;
		
	/**
	 * 
	 */
	_walkAnime : boolean;
		
	/**
	 * 
	 */
	_stepAnime : boolean;
		
	/**
	 * 
	 */
	_directionFix : boolean;
		
	/**
	 * 
	 */
	_through : boolean;
		
	/**
	 * 
	 */
	_transparent : boolean;
		
	/**
	 * 
	 */
	_bushDepth : number;
		
	/**
	 * 
	 */
	_animationId : number;
		
	/**
	 * 
	 */
	_balloonId : number;
		
	/**
	 * 
	 */
	_animationPlaying : boolean;
		
	/**
	 * 
	 */
	_balloonPlaying : boolean;
		
	/**
	 * 
	 */
	_animationCount : number;
		
	/**
	 * 
	 */
	_stopCount : number;
		
	/**
	 * 
	 */
	_jumpCount : number;
		
	/**
	 * 
	 */
	_jumpPeak : number;
		
	/**
	 * 
	 */
	_movementSuccess : boolean;
}

/**
 * -----------------------------------------------------------------------------
 * Game_Followers
 * 
 * The wrapper class for a follower array.
 */
declare interface Game_Followers {
		
	/**
	 * 
	 */
	new ();
		
	/**
	 * 
	 */
	initialize(): void;
		
	/**
	 * 
	 * @return  
	 */
    isVisible(): /* !this._visible */ boolean;
		
	/**
	 * 
	 */
	show(): void;
		
	/**
	 * 
	 */
	hide(): void;
		
	/**
	 * 
	 * @param index 
	 * @return  
	 */
    follower(index: number): /* !this._data.<i> */ Game_Follower;
		
	/**
	 * 
	 * @param callback 
	 * @param thisObject 
	 */
	forEach(callback : Game_Followers.prototype.ForEach0, thisObject : Game_Followers): void;
		
	/**
	 * 
	 * @param callback 
	 * @param thisObject 
	 */
    reverseEach(callback: Function, thisObject : this): void;
		
	/**
	 * 
	 */
	refresh(): void;
		
	/**
	 * 
	 */
	update(): void;
		
	/**
	 * 
	 */
	updateMove(): void;
		
	/**
	 * 
	 */
	jumpAll(): void;
		
	/**
	 * 
	 * @param x 
	 * @param y 
	 * @param d 
	 */
	synchronize(x : number, y : number, d : number): void;
		
	/**
	 * 
	 */
	gather(): void;
		
	/**
	 * 
	 * @return  
	 */
    areGathering(): /* !this._gathering */ boolean;
		
	/**
	 * 
	 * @return  
	 */
	visibleFollowers(): Game_Followers.prototype.VisibleFollowersRet;
		
	/**
	 * 
	 * @return  
	 */
	areMoving(): boolean;
		
	/**
	 * 
	 * @return  
	 */
	areGathered(): boolean;
		
	/**
	 * 
	 * @param x 
	 * @param y 
	 * @return  
	 */
	isSomeoneCollided(x : number, y : number): boolean;
		
	/**
	 * 
	 */
	_visible : boolean;
		
	/**
	 * 
	 */
	_gathering : boolean;
		
	/**
	 * 
	 */
    _data: Array</* Game_Followers.+Game_Follower */ Game_Follower>;
}

/**
 * -----------------------------------------------------------------------------
 * Game_Vehicle
 * 
 * The game object class for a vehicle.
 */
declare interface Game_Vehicle extends Game_Character {
		
	/**
	 * 
	 */
	new ();
		
	/**
	 * 
	 * @param type 
	 */
    initialize(type: string): void;
		
	/**
	 * 
	 */
	initMembers(): void;
		
	/**
	 * 
	 * @return  
	 */
	isBoat(): boolean;
		
	/**
	 * 
	 * @return  
	 */
	isShip(): boolean;
		
	/**
	 * 
	 * @return  
	 */
	isAirship(): boolean;
		
	/**
	 * 
	 */
	resetDirection(): void;
		
	/**
	 * 
	 */
	initMoveSpeed(): void;
		
	/**
	 * 
	 */
	vehicle(): void;
		
	/**
	 * 
	 */
	loadSystemSettings(): void;
		
	/**
	 * 
	 */
	refresh(): void;
		
	/**
	 * 
	 * @param mapId 
	 * @param x 
	 * @param y 
	 */
	setLocation(mapId : number, x : number, y : number): void;
		
	/**
	 * 
	 * @param x 
	 * @param y 
	 * @return  
	 */
	pos(x : number, y : number): boolean;
		
	/**
	 * 
	 * @param x 
	 * @param y 
	 * @param d 
	 * @return  
	 */
	isMapPassable(x : number, y : number, d : number): boolean;
		
	/**
	 * 
	 */
	getOn(): void;
		
	/**
	 * 
	 */
	getOff(): void;
		
	/**
	 * 
	 * @param bgm 
	 */
    setBgm(bgm: IAudioObject): void;
		
	/**
	 * 
	 */
	playBgm(): void;
		
	/**
	 * 
	 */
	syncWithPlayer(): void;
		
	/**
	 * 
	 * @return  
	 */
	screenY(): number;
		
	/**
	 * 
	 * @return  
	 */
	shadowX(): number;
		
	/**
	 * 
	 * @return  
	 */
	shadowY(): number;
		
	/**
	 * 
	 * @return  
	 */
	shadowOpacity(): number;
		
	/**
	 * 
	 * @return  
	 */
	canMove(): boolean;
		
	/**
	 * 
	 */
	update(): void;
		
	/**
	 * 
	 */
	updateAirship(): void;
		
	/**
	 * 
	 */
	updateAirshipAltitude(): void;
		
	/**
	 * 
	 * @return  
	 */
	maxAltitude(): number;
		
	/**
	 * 
	 * @return  
	 */
	isLowest(): boolean;
		
	/**
	 * 
	 * @return  
	 */
	isHighest(): boolean;
		
	/**
	 * 
	 */
	isTakeoffOk(): void;
		
	/**
	 * 
	 * @param x 
	 * @param y 
	 * @param d 
	 * @return  
	 */
	isLandOk(x : number, y : number, d : number): boolean;
		
	/**
	 * 
	 */
	_realX : number;
		
	/**
	 * 
	 */
	_realY : number;
		
	/**
	 * 
	 */
	_x : number;
		
	/**
	 * 
	 */
	_y : number;
		
	/**
	 * 
	 */
	_animationCount : number;
		
	/**
	 * 
	 */
	_bushDepth : number;
		
	/**
	 * 
	 */
	_pattern : number;
		
	/**
	 * 
	 */
	_moveRouteForcing : boolean;
		
	/**
	 * 
	 */
	_moveRouteIndex : number;
		
	/**
	 * 
	 */
	_originalMoveRouteIndex : number;
		
	/**
	 * 
	 */
	_waitCount : number;
		
	/**
	 * 
	 */
	_movementSuccess : boolean;
		
	/**
	 * 
	 */
	_moveSpeed : number;
		
	/**
	 * 
	 */
	_moveFrequency : number;
		
	/**
	 * 
	 */
	_opacity : number;
		
	/**
	 * 
	 */
	_blendMode : number;
		
	/**
	 * 
	 */
	_direction : number;
		
	/**
	 * 
	 */
	_priorityType : number;
		
	/**
	 * 
	 */
	_tileId : number;
		
	/**
	 * 
	 */
	_characterName : string;
		
	/**
	 * 
	 */
	_characterIndex : number;
		
	/**
	 * 
	 */
	_isObjectCharacter : boolean;
		
	/**
	 * 
	 */
	_walkAnime : boolean;
		
	/**
	 * 
	 */
	_stepAnime : boolean;
		
	/**
	 * 
	 */
	_directionFix : boolean;
		
	/**
	 * 
	 */
	_through : boolean;
		
	/**
	 * 
	 */
	_transparent : boolean;
		
	/**
	 * 
	 */
	_animationId : number;
		
	/**
	 * 
	 */
	_balloonId : number;
		
	/**
	 * 
	 */
	_animationPlaying : boolean;
		
	/**
	 * 
	 */
	_balloonPlaying : boolean;
		
	/**
	 * 
	 */
	_stopCount : number;
		
	/**
	 * 
	 */
	_jumpCount : number;
		
	/**
	 * 
	 */
	_jumpPeak : number;
		
	/**
	 * 
	 */
	_type : string;
		
	/**
	 * 
	 */
	_mapId : number;
		
	/**
	 * 
	 */
	_altitude : number;
		
	/**
	 * 
	 */
	_driving : boolean;
}

/**
 * -----------------------------------------------------------------------------
 * Game_Event
 * 
 * The game object class for an event. It contains functionality for event page
 * switching and running parallel process events.
 */
declare interface Game_Event extends Game_Character {
		
	/**
	 * 
	 */
	new ();
		
	/**
	 * 
	 * @param mapId 
	 * @param eventId 
	 */
	initialize(mapId : number, eventId : number): void;
		
	/**
	 * 
	 */
	initMembers(): void;
		
	/**
	 * 
	 * @return  
	 */
    eventId(): /* !this._eventId */ number;
		
	/**
	 * 
	 */
	event(): void;
		
	/**
	 * 
	 */
	page(): void;
		
	/**
	 * 
	 */
	list(): void;
		
	/**
	 * 
	 * @param x 
	 * @param y 
	 * @return  
	 */
	isCollidedWithCharacters(x : number, y : number): boolean;
		
	/**
	 * 
	 * @param x 
	 * @param y 
	 * @return  
	 */
	isCollidedWithEvents(x : number, y : number): boolean;
		
	/**
	 * 
	 * @param x 
	 * @param y 
	 * @return  
	 */
	isCollidedWithPlayerCharacters(x : number, y : number): boolean;
		
	/**
	 * 
	 */
	lock(): void;
		
	/**
	 * 
	 */
	unlock(): void;
		
	/**
	 * 
	 */
	updateStop(): void;
		
	/**
	 * 
	 */
	updateSelfMovement(): void;
		
	/**
	 * 
	 * @return  
	 */
	stopCountThreshold(): number;
		
	/**
	 * 
	 */
	moveTypeRandom(): void;
		
	/**
	 * 
	 */
	moveTypeTowardPlayer(): void;
		
	/**
	 * 
	 * @return  
	 */
	isNearThePlayer(): boolean;
		
	/**
	 * 
	 */
	moveTypeCustom(): void;
		
	/**
	 * 
	 * @return  
	 */
    isStarting(): /* !this._starting */ boolean;
		
	/**
	 * 
	 */
	clearStartingFlag(): void;
		
	/**
	 * 
	 * @param triggers 
	 */
	isTriggerIn(triggers : Game_Event.prototype.IsTriggerIn0): void;
		
	/**
	 * 
	 */
	start(): void;
		
	/**
	 * 
	 */
	erase(): void;
		
	/**
	 * 
	 */
	refresh(): void;
		
	/**
	 * 
	 * @return  
	 */
	findProperPageIndex(): number;
		
	/**
	 * 
	 * @param page 
	 * @return  
	 */
    meetsConditions(page: IDataMapEventPage): boolean;
		
	/**
	 * 
	 */
	setupPage(): void;
		
	/**
	 * 
	 */
	clearPageSettings(): void;
		
	/**
	 * 
	 */
	setupPageSettings(): void;
		
	/**
	 * 
	 * @return  
	 */
	isOriginalPattern(): boolean;
		
	/**
	 * 
	 */
	resetPattern(): void;
		
	/**
	 * 
	 * @param x 
	 * @param y 
	 */
	checkEventTriggerTouch(x : number, y : number): void;
		
	/**
	 * 
	 */
	checkEventTriggerAuto(): void;
		
	/**
	 * 
	 */
	update(): void;
		
	/**
	 * 
	 */
	updateParallel(): void;
		
	/**
	 * 
	 * @param x 
	 * @param y 
	 */
	locate(x : number, y : number): void;
		
	/**
	 * 
	 * @param moveRoute 
	 */
    forceMoveRoute(moveRoute: IDataMoveRoute): void;
		
	/**
	 * 
	 */
	_realX : number;
		
	/**
	 * 
	 */
	_realY : number;
		
	/**
	 * 
	 */
	_x : number;
		
	/**
	 * 
	 */
	_y : number;
		
	/**
	 * 
	 */
	_animationCount : number;
		
	/**
	 * 
	 */
	_bushDepth : number;
		
	/**
	 * 
	 */
	_pattern : number;
		
	/**
	 * 
	 */
	_moveRouteForcing : boolean;
		
	/**
	 * 
	 */
	_moveRouteIndex : number;
		
	/**
	 * 
	 */
	_originalMoveRouteIndex : number;
		
	/**
	 * 
	 */
	_waitCount : number;
		
	/**
	 * 
	 */
	_movementSuccess : boolean;
		
	/**
	 * 
	 */
	_moveSpeed : number;
		
	/**
	 * 
	 */
	_moveFrequency : number;
		
	/**
	 * 
	 */
	_opacity : number;
		
	/**
	 * 
	 */
	_blendMode : number;
		
	/**
	 * 
	 */
	_direction : number;
		
	/**
	 * 
	 */
	_priorityType : number;
		
	/**
	 * 
	 */
	_tileId : number;
		
	/**
	 * 
	 */
	_characterName : string;
		
	/**
	 * 
	 */
	_characterIndex : number;
		
	/**
	 * 
	 */
	_isObjectCharacter : boolean;
		
	/**
	 * 
	 */
	_walkAnime : boolean;
		
	/**
	 * 
	 */
	_stepAnime : boolean;
		
	/**
	 * 
	 */
	_directionFix : boolean;
		
	/**
	 * 
	 */
	_through : boolean;
		
	/**
	 * 
	 */
	_transparent : boolean;
		
	/**
	 * 
	 */
	_animationId : number;
		
	/**
	 * 
	 */
	_balloonId : number;
		
	/**
	 * 
	 */
	_animationPlaying : boolean;
		
	/**
	 * 
	 */
	_balloonPlaying : boolean;
		
	/**
	 * 
	 */
	_stopCount : number;
		
	/**
	 * 
	 */
	_jumpCount : number;
		
	/**
	 * 
	 */
	_jumpPeak : number;
		
	/**
	 * 
	 */
	_moveType : number;
		
	/**
	 * 
	 */
	_trigger : number;
		
	/**
	 * 
	 */
	_starting : boolean;
		
	/**
	 * 
	 */
	_erased : boolean;
		
	/**
	 * 
	 */
	_pageIndex : number;
		
	/**
	 * 
	 */
	_originalPattern : number;
		
	/**
	 * 
	 */
	_originalDirection : number;
		
	/**
	 * 
	 */
	_prelockDirection : number;
		
	/**
	 * 
	 */
	_locked : boolean;
		
	/**
	 * 
	 */
	_interpreter : Game_Interpreter;
}

/**
 * -----------------------------------------------------------------------------
 * Game_Interpreter
 * 
 * The interpreter for running event commands.
 */
declare interface Game_Interpreter {
		
	/**
	 * 
	 */
	new ();
		
	/**
	 * 
	 * @param depth 
	 */
	initialize(depth : number): void;
		
	/**
	 * 
	 */
	checkOverflow(): void;
		
	/**
	 * 
	 */
	clear(): void;
		
	/**
	 * 
	 * @param list 
	 * @param eventId 
	 */
    setup(list: IDataMapEventPageList[], eventId?: number): void;
		
	/**
	 * 
	 * @return  
	 */
    eventId(): /* !this._eventId */ number;
		
	/**
	 * 
	 * @return  
	 */
	isOnCurrentMap(): boolean;
		
	/**
	 * 
	 * @return  
	 */
	setupReservedCommonEvent(): boolean;
		
	/**
	 * 
	 * @return  
	 */
	isRunning(): boolean;
		
	/**
	 * 
	 */
	update(): void;
		
	/**
	 * 
	 * @return  
	 */
	updateChild(): boolean;
		
	/**
	 * 
	 * @return  
	 */
	updateWait(): boolean;
		
	/**
	 * 
	 * @return  
	 */
	updateWaitCount(): boolean;
		
	/**
	 * 
	 * @return  
	 */
	updateWaitMode(): boolean;
		
	/**
	 * 
	 * @param waitMode 
	 */
	setWaitMode(waitMode : string): void;
		
	/**
	 * 
	 * @param duration 
	 */
	wait(duration : number): void;
		
	/**
	 * 
	 * @return  
	 */
	fadeSpeed(): number;
		
	/**
	 * 
	 * @return  
	 */
	executeCommand(): boolean;
		
	/**
	 * 
	 * @return  
	 */
	checkFreeze(): boolean;
		
	/**
	 * 
	 */
	terminate(): void;
		
	/**
	 * 
	 */
	skipBranch(): void;
		
	/**
	 * 
	 * @return  
	 */
    currentCommand(): /* !this._list.<i> */ IDataMapEventPageList;
		
	/**
	 * 
	 * @return  
	 */
	nextEventCode(): number;
		
	/**
	 * 
	 * @param param 
	 * @param callback 
	 */
	iterateActorId(param : number, callback : Game_Interpreter.prototype.IterateActorId1): void;
		
	/**
	 * 
	 * @param param1 
	 * @param param2 
	 * @param callback 
	 */
	iterateActorEx(param1 : number, param2 : number, callback : Game_Interpreter.prototype.IterateActorEx2): void;
		
	/**
	 * 
	 * @param param 
	 * @param callback 
	 */
    iterateActorIndex(param: number, callback: Function): void;
		
	/**
	 * 
	 * @param param 
	 * @param callback 
	 */
	iterateEnemyIndex(param : number, callback : () => void): void;
		
	/**
	 * 
	 * @param param1 
	 * @param param2 
	 * @param callback 
	 */
	iterateBattler(param1 : number, param2 : number, callback : () => void): void;
		
	/**
	 * 
	 * @param param 
	 */
	character(param : number): void;
		
	/**
	 * 
	 * @param operation 
	 * @param operandType 
	 * @param operand 
	 * @return  
	 */
    operateValue(operation: number, operandType: number, operand: number): number;
		
	/**
	 * 
	 * @param target 
	 * @param value 
	 * @param allowDeath 
	 */
    changeHp(target: Game_Battler, value: number, allowDeath: boolean): void;
		
	/**
	 * Show Text
	 * @return  
	 */
	command101(): boolean;
		
	/**
	 * Show Choices
	 * @return  
	 */
	command102(): boolean;
		
	/**
	 * 
	 * @param params 
	 */
    //setupChoices(params: Array<any>): void;
    setupChoices(params: (number | string)[]): void;
		
	/**
	 * When [**]
	 * @return  
	 */
	command402(): boolean;
		
	/**
	 * When Cancel
	 * @return  
	 */
	command403(): boolean;
		
	/**
	 * Input Number
	 * @return  
	 */
	command103(): boolean;
		
	/**
	 * 
	 * @param params 
	 */
	//setupNumInput(params : Array<any>): void;
    setupNumInput(params:(number|string)[]): void;
		
	/**
	 * Select Item
	 * @return  
	 */
	command104(): boolean;
		
	/**
	 * 
	 * @param params 
	 */
	//setupItemChoice(params : Array<any>): void;
    setupItemChoice(params: (number | string)[]): void;
		
	/**
	 * Show Scrolling Text
	 * @return  
	 */
	command105(): boolean;
		
	/**
	 * Comment
	 * @return  
	 */
	command108(): boolean;
		
	/**
	 * Conditional Branch
	 * @return  
	 */
	command111(): boolean;
		
	/**
	 * Else
	 * @return  
	 */
	command411(): boolean;
		
	/**
	 * Loop
	 * @return  
	 */
	command112(): boolean;
		
	/**
	 * Repeat Above
	 * @return  
	 */
	command413(): boolean;
		
	/**
	 * Break Loop
	 * @return  
	 */
	command113(): boolean;
		
	/**
	 * Exit Event Processing
	 * @return  
	 */
	command115(): boolean;
		
	/**
	 * Common Event
	 * @return  
	 */
	command117(): boolean;
		
	/**
	 * 
	 * @param list 
	 * @param eventId 
	 */
    setupChild(list: IDataMapEventPageList[], eventId : number): void;
		
	/**
	 * Label
	 * @return  
	 */
	command118(): boolean;
		
	/**
	 * Jump to Label
	 * @return  
	 */
	command119(): boolean;
		
	/**
	 * 
	 * @param index 
	 */
	jumpTo(index : number): void;
		
	/**
	 * Control Switches
	 * @return  
	 */
	command121(): boolean;
		
	/**
	 * Control Variables
	 * @return  
	 */
	command122(): boolean;
		
	/**
	 * 
	 * @param type 
	 * @param param1 
	 * @param param2 
	 * @return  
	 */
    gameDataOperand(type: number, param1 : number, param2 : number): number;
		
	/**
	 * 
	 * @param variableId 
	 * @param operationType 
	 * @param value 
	 */
    operateVariable(variableId: number, operationType: number, value : number): void;
		
	/**
	 * Control Self Switch
	 * @return  
	 */
	command123(): boolean;
		
	/**
	 * Control Timer
	 * @return  
	 */
	command124(): boolean;
		
	/**
	 * Change Gold
	 * @return  
	 */
	command125(): boolean;
		
	/**
	 * Change Items
	 * @return  
	 */
	command126(): boolean;
		
	/**
	 * Change Weapons
	 * @return  
	 */
	command127(): boolean;
		
	/**
	 * Change Armors
	 * @return  
	 */
	command128(): boolean;
		
	/**
	 * Change Party Member
	 * @return  
	 */
	command129(): boolean;
		
	/**
	 * Change Battle BGM
	 * @return  
	 */
	command132(): boolean;
		
	/**
	 * Change Victory ME
	 * @return  
	 */
	command133(): boolean;
		
	/**
	 * Change Save Access
	 * @return  
	 */
	command134(): boolean;
		
	/**
	 * Change Menu Access
	 * @return  
	 */
	command135(): boolean;
		
	/**
	 * Change Encounter Disable
	 * @return  
	 */
	command136(): boolean;
		
	/**
	 * Change Formation Access
	 * @return  
	 */
	command137(): boolean;
		
	/**
	 * Change Window Color
	 * @return  
	 */
	command138(): boolean;
		
	/**
	 * Change Defeat ME
	 * @return  
	 */
	command139(): boolean;
		
	/**
	 * Change Vehicle BGM
	 * @return  
	 */
	command140(): boolean;
		
	/**
	 * Transfer Player
	 * @return  
	 */
	command201(): boolean;
		
	/**
	 * Set Vehicle Location
	 * @return  
	 */
	command202(): boolean;
		
	/**
	 * Set Event Location
	 * @return  
	 */
	command203(): boolean;
		
	/**
	 * Scroll Map
	 * @return  
	 */
	command204(): boolean;
		
	/**
	 * Set Movement Route
	 * @return  
	 */
	command205(): boolean;
		
	/**
	 * Getting On and Off Vehicles
	 * @return  
	 */
	command206(): boolean;
		
	/**
	 * Change Transparency
	 * @return  
	 */
	command211(): boolean;
		
	/**
	 * Show Animation
	 * @return  
	 */
	command212(): boolean;
		
	/**
	 * Show Balloon Icon
	 * @return  
	 */
	command213(): boolean;
		
	/**
	 * Erase Event
	 * @return  
	 */
	command214(): boolean;
		
	/**
	 * Change Player Followers
	 * @return  
	 */
	command216(): boolean;
		
	/**
	 * Gather Followers
	 * @return  
	 */
	command217(): boolean;
		
	/**
	 * Fadeout Screen
	 * @return  
	 */
	command221(): boolean;
		
	/**
	 * Fadein Screen
	 * @return  
	 */
	command222(): boolean;
		
	/**
	 * Tint Screen
	 * @return  
	 */
	command223(): boolean;
		
	/**
	 * Flash Screen
	 * @return  
	 */
	command224(): boolean;
		
	/**
	 * Shake Screen
	 * @return  
	 */
	command225(): boolean;
		
	/**
	 * Wait
	 * @return  
	 */
	command230(): boolean;
		
	/**
	 * Show Picture
	 * @return  
	 */
	command231(): boolean;
		
	/**
	 * Move Picture
	 * @return  
	 */
	command232(): boolean;
		
	/**
	 * Rotate Picture
	 * @return  
	 */
	command233(): boolean;
		
	/**
	 * Tint Picture
	 * @return  
	 */
	command234(): boolean;
		
	/**
	 * Erase Picture
	 * @return  
	 */
	command235(): boolean;
		
	/**
	 * Set Weather Effect
	 * @return  
	 */
	command236(): boolean;
		
	/**
	 * Play BGM
	 * @return  
	 */
	command241(): boolean;
		
	/**
	 * Fadeout BGM
	 * @return  
	 */
	command242(): boolean;
		
	/**
	 * Save BGM
	 * @return  
	 */
	command243(): boolean;
		
	/**
	 * Resume BGM
	 * @return  
	 */
	command244(): boolean;
		
	/**
	 * Play BGS
	 * @return  
	 */
	command245(): boolean;
		
	/**
	 * Fadeout BGS
	 * @return  
	 */
	command246(): boolean;
		
	/**
	 * Play ME
	 * @return  
	 */
	command249(): boolean;
		
	/**
	 * Play SE
	 * @return  
	 */
	command250(): boolean;
		
	/**
	 * Stop SE
	 * @return  
	 */
	command251(): boolean;
		
	/**
	 * Play Movie
	 * @return  
	 */
	command261(): boolean;
		
	/**
	 * 
	 * @return  
	 */
	videoFileExt(): string;
		
	/**
	 * Change Map Name Display
	 * @return  
	 */
	command281(): boolean;
		
	/**
	 * Change Tileset
	 * @return  
	 */
	command282(): boolean;
		
	/**
	 * Change Battle Back
	 * @return  
	 */
	command283(): boolean;
		
	/**
	 * Change Parallax
	 * @return  
	 */
	command284(): boolean;
		
	/**
	 * Get Location Info
	 * @return  
	 */
	command285(): boolean;
		
	/**
	 * Battle Processing
	 * @return  
	 */
	command301(): boolean;
		
	/**
	 * If Win
	 * @return  
	 */
	command601(): boolean;
		
	/**
	 * If Escape
	 * @return  
	 */
	command602(): boolean;
		
	/**
	 * If Lose
	 * @return  
	 */
	command603(): boolean;
		
	/**
	 * Shop Processing
	 * @return  
	 */
	command302(): boolean;
		
	/**
	 * Name Input Processing
	 * @return  
	 */
	command303(): boolean;
		
	/**
	 * Change HP
	 * @return  
	 */
	command311(): boolean;
		
	/**
	 * Change MP
	 * @return  
	 */
	command312(): boolean;
		
	/**
	 * Change TP
	 * @return  
	 */
	command326(): boolean;
		
	/**
	 * Change State
	 * @return  
	 */
	command313(): boolean;
		
	/**
	 * Recover All
	 * @return  
	 */
	command314(): boolean;
		
	/**
	 * Change EXP
	 * @return  
	 */
	command315(): boolean;
		
	/**
	 * Change Level
	 * @return  
	 */
	command316(): boolean;
		
	/**
	 * Change Parameter
	 * @return  
	 */
	command317(): boolean;
		
	/**
	 * Change Skill
	 * @return  
	 */
	command318(): boolean;
		
	/**
	 * Change Equipment
	 * @return  
	 */
	command319(): boolean;
		
	/**
	 * Change Name
	 * @return  
	 */
	command320(): boolean;
		
	/**
	 * Change Class
	 * @return  
	 */
	command321(): boolean;
		
	/**
	 * Change Actor Images
	 * @return  
	 */
	command322(): boolean;
		
	/**
	 * Change Vehicle Image
	 * @return  
	 */
	command323(): boolean;
		
	/**
	 * Change Nickname
	 * @return  
	 */
	command324(): boolean;
		
	/**
	 * Change Profile
	 * @return  
	 */
	command325(): boolean;
		
	/**
	 * Change Enemy HP
	 * @return  
	 */
	command331(): boolean;
		
	/**
	 * Change Enemy MP
	 * @return  
	 */
	command332(): boolean;
		
	/**
	 * Change Enemy TP
	 * @return  
	 */
	command342(): boolean;
		
	/**
	 * Change Enemy State
	 * @return  
	 */
	command333(): boolean;
		
	/**
	 * Enemy Recover All
	 * @return  
	 */
	command334(): boolean;
		
	/**
	 * Enemy Appear
	 * @return  
	 */
	command335(): boolean;
		
	/**
	 * Enemy Transform
	 * @return  
	 */
	command336(): boolean;
		
	/**
	 * Show Battle Animation
	 * @return  
	 */
	command337(): boolean;
		
	/**
	 * Force Action
	 * @return  
	 */
	command339(): boolean;
		
	/**
	 * Abort Battle
	 * @return  
	 */
	command340(): boolean;
		
	/**
	 * Open Menu Screen
	 * @return  
	 */
	command351(): boolean;
		
	/**
	 * Open Save Screen
	 * @return  
	 */
	command352(): boolean;
		
	/**
	 * Game Over
	 * @return  
	 */
	command353(): boolean;
		
	/**
	 * Return to Title Screen
	 * @return  
	 */
	command354(): boolean;
		
	/**
	 * Script
	 * @return  
	 */
	command355(): boolean;
		
	/**
	 * Plugin Command
	 * @return  
	 */
	command356(): boolean;
		
	/**
	 * 
	 * @param command 
	 * @param args 
	 */
    pluginCommand(command: string, args: string[]): void;
		
	/**
	 * 
	 * @param list 
	 * @param commonList 
	 */
    requestImages(list: /* Game_Interpreter.+Game_Followers */ Game_Followers, commonList : Game_Interpreter.RequestImages1): void;
		
	/**
	 * 
	 */
	_depth : number;
	
	/**
	 * 
	 */
	_branch : {
	}
		
	/**
	 * 
	 */
	_params : Array<any>;
		
	/**
	 * 
	 */
	_indent : number;
		
	/**
	 * 
	 */
	_frameCount : number;
		
	/**
	 * 
	 */
	_freezeChecker : number;
		
	/**
	 * 
	 */
	_mapId : number;
		
	/**
	 * 
	 */
	_eventId : number;
		
	/**
	 * 
	 */
	_index : number;
		
	/**
	 * 
	 */
	_waitCount : number;
		
	/**
	 * 
	 */
	_waitMode : string;
}