// Type definitions for rpg_sprites.js
// Project: [LIBRARY_URL_HERE] 
// Definitions by: [YOUR_NAME_HERE] <[YOUR_URL_HERE]> 
// Definitions: https://github.com/borisyankov/DefinitelyTyped
declare namespace Sprite_Animation.prototype{
	// Sprite_Animation.prototype.updateCellSprite.!0
	
	/**
	 * 
	 */
	interface UpdateCellSprite0 {
				
		/**
		 * 
		 */
		visible : boolean;
				
		/**
		 * 
		 */
		x : number;
				
		/**
		 * 
		 */
		rotation : number;
	}
}
declare namespace Sprite_Animation.prototype{
	// Sprite_Animation.prototype.startScreenFlash.!0
	type StartScreenFlash0 = Array</* number,number,number,number */ any>;
}
declare namespace Sprite_Damage.prototype{
	// Sprite_Damage.prototype.createChildSprite.!ret
	
	/**
	 * 
	 */
	interface CreateChildSpriteRet {
				
		/**
		 * 
		 */
		y : number;
				
		/**
		 * 
		 */
		ry : number;
				
		/**
		 * 
		 */
		dy : number;
				
		/**
		 * 
		 */
		x : number;
	}
}
declare namespace Sprite_Damage.prototype{
	// Sprite_Damage.prototype.updateChild.!0
	
	/**
	 * 
	 */
	interface UpdateChild0 {
				
		/**
		 * 
		 */
		dy : number;
				
		/**
		 * 
		 */
		ry : number;
				
		/**
		 * 
		 */
		y : number;
	}
}

/**
 * -----------------------------------------------------------------------------
 * Sprite_Base
 * 
 * The sprite class with a feature which displays animations.
 */
declare interface Sprite_Base {
		
	/**
	 * 
	 * @return  
	 */
	new (): Sprite_Base;
}


/**
 * -----------------------------------------------------------------------------
 * Sprite_Button
 * 
 * The sprite for displaying a button.
 */
declare interface Sprite_Button {
		
	/**
	 * 
	 * @return  
	 */
	new (): Sprite_Button;
}


/**
 * -----------------------------------------------------------------------------
 * Sprite_Character
 * 
 * The sprite for displaying a character.
 */
declare interface Sprite_Character {
		
	/**
	 * 
	 * @return  
	 */
	new (): Sprite_Character;
}


/**
 * -----------------------------------------------------------------------------
 * Sprite_Battler
 * 
 * The superclass of Sprite_Actor and Sprite_Enemy.
 */
declare interface Sprite_Battler {
		
	/**
	 * 
	 * @return  
	 */
	new (): Sprite_Battler;
}


/**
 * -----------------------------------------------------------------------------
 * Sprite_Actor
 * 
 * The sprite for displaying an actor.
 */
declare interface Sprite_Actor {
		
	/**
	 * 
	 * @return  
	 */
	new (): Sprite_Actor;
}


/**
 * 
 */
declare namespace Sprite_Actor{
	
	/**
	 * 
	 */
	namespace MOTIONS{
		
		/**
		 * 
		 */
		namespace walk{
						
			/**
			 * 
			 */
			export var index : number;
						
			/**
			 * 
			 */
			export var loop : boolean;
		}
		
		/**
		 * 
		 */
		namespace wait{
						
			/**
			 * 
			 */
			export var index : number;
						
			/**
			 * 
			 */
			export var loop : boolean;
		}
		
		/**
		 * 
		 */
		namespace chant{
						
			/**
			 * 
			 */
			export var index : number;
						
			/**
			 * 
			 */
			export var loop : boolean;
		}
		
		/**
		 * 
		 */
		namespace guard{
						
			/**
			 * 
			 */
			export var index : number;
						
			/**
			 * 
			 */
			export var loop : boolean;
		}
		
		/**
		 * 
		 */
		namespace damage{
						
			/**
			 * 
			 */
			export var index : number;
						
			/**
			 * 
			 */
			export var loop : boolean;
		}
		
		/**
		 * 
		 */
		namespace evade{
						
			/**
			 * 
			 */
			export var index : number;
						
			/**
			 * 
			 */
			export var loop : boolean;
		}
		
		/**
		 * 
		 */
		namespace thrust{
						
			/**
			 * 
			 */
			export var index : number;
						
			/**
			 * 
			 */
			export var loop : boolean;
		}
		
		/**
		 * 
		 */
		namespace swing{
						
			/**
			 * 
			 */
			export var index : number;
						
			/**
			 * 
			 */
			export var loop : boolean;
		}
		
		/**
		 * 
		 */
		namespace missile{
						
			/**
			 * 
			 */
			export var index : number;
						
			/**
			 * 
			 */
			export var loop : boolean;
		}
		
		/**
		 * 
		 */
		namespace skill{
						
			/**
			 * 
			 */
			export var index : number;
						
			/**
			 * 
			 */
			export var loop : boolean;
		}
		
		/**
		 * 
		 */
		namespace spell{
						
			/**
			 * 
			 */
			export var index : number;
						
			/**
			 * 
			 */
			export var loop : boolean;
		}
		
		/**
		 * 
		 */
		namespace item{
						
			/**
			 * 
			 */
			export var index : number;
						
			/**
			 * 
			 */
			export var loop : boolean;
		}
		
		/**
		 * 
		 */
		namespace escape{
						
			/**
			 * 
			 */
			export var index : number;
						
			/**
			 * 
			 */
			export var loop : boolean;
		}
		
		/**
		 * 
		 */
		namespace victory{
						
			/**
			 * 
			 */
			export var index : number;
						
			/**
			 * 
			 */
			export var loop : boolean;
		}
		
		/**
		 * 
		 */
		namespace dying{
						
			/**
			 * 
			 */
			export var index : number;
						
			/**
			 * 
			 */
			export var loop : boolean;
		}
		
		/**
		 * 
		 */
		namespace abnormal{
						
			/**
			 * 
			 */
			export var index : number;
						
			/**
			 * 
			 */
			export var loop : boolean;
		}
		
		/**
		 * 
		 */
		namespace sleep{
						
			/**
			 * 
			 */
			export var index : number;
						
			/**
			 * 
			 */
			export var loop : boolean;
		}
		
		/**
		 * 
		 */
		namespace dead{
						
			/**
			 * 
			 */
			export var index : number;
						
			/**
			 * 
			 */
			export var loop : boolean;
		}
	}
}

/**
 * -----------------------------------------------------------------------------
 * Sprite_Enemy
 * 
 * The sprite for displaying an enemy.
 */
declare interface Sprite_Enemy {
		
	/**
	 * 
	 * @return  
	 */
	new (): Sprite_Enemy;
}


/**
 * -----------------------------------------------------------------------------
 * Sprite_Animation
 * 
 * The sprite for displaying an animation.
 */
declare interface Sprite_Animation {
		
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
	 * @param target 
	 * @param animation 
	 * @param mirror 
	 * @param delay 
	 */
	setup(target : any, animation : any, mirror : any, delay : any): void;
		
	/**
	 * 
	 */
	remove(): void;
		
	/**
	 * 
	 */
	setupRate(): void;
		
	/**
	 * 
	 */
	setupDuration(): void;
		
	/**
	 * 
	 */
	update(): void;
		
	/**
	 * 
	 */
	updateFlash(): void;
		
	/**
	 * 
	 */
	updateScreenFlash(): void;
		
	/**
	 * 
	 * @return  
	 */
	absoluteX(): number;
		
	/**
	 * 
	 * @return  
	 */
	absoluteY(): number;
		
	/**
	 * 
	 */
	updateHiding(): void;
		
	/**
	 * 
	 * @return  
	 */
	isPlaying(): boolean;
		
	/**
	 * 
	 */
	loadBitmaps(): void;
		
	/**
	 * 
	 * @return  
	 */
	isReady(): /* !this._bitmap1 */ any;
		
	/**
	 * 
	 */
	createSprites(): void;
		
	/**
	 * 
	 */
	createCellSprites(): void;
		
	/**
	 * 
	 */
	createScreenFlashSprite(): void;
		
	/**
	 * 
	 */
	updateMain(): void;
		
	/**
	 * 
	 */
	updatePosition(): void;
		
	/**
	 * 
	 */
	updateFrame(): void;
		
	/**
	 * 
	 * @return  
	 */
	currentFrameIndex(): number;
		
	/**
	 * 
	 * @param frame 
	 */
	updateAllCellSprites(frame : any): void;
		
	/**
	 * 
	 * @param sprite 
	 * @param cell 
	 */
	updateCellSprite(sprite : Sprite_Animation.prototype.UpdateCellSprite0, cell : any): void;
		
	/**
	 * 
	 * @param timing 
	 */
	processTimingData(timing : any): void;
		
	/**
	 * 
	 * @param color 
	 * @param duration 
	 */
	startFlash(color : any, duration : number): void;
		
	/**
	 * 
	 * @param color 
	 * @param duration 
	 */
	startScreenFlash(color : Sprite_Animation.prototype.StartScreenFlash0, duration : number): void;
		
	/**
	 * 
	 * @param duration 
	 */
	startHiding(duration : number): void;
	
	/**
	 * 
	 */
	_checker1 : {
	}
	
	/**
	 * 
	 */
	_checker2 : {
	}
}

/**
 * -----------------------------------------------------------------------------
 * Sprite_Damage
 * 
 * The sprite for displaying a popup damage.
 */
declare interface Sprite_Damage {
		
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
	 * @param target 
	 */
	setup(target : any): void;
		
	/**
	 * 
	 */
	setupCriticalEffect(): void;
		
	/**
	 * 
	 * @return  
	 */
	digitWidth(): number;
		
	/**
	 * 
	 * @return  
	 */
	digitHeight(): number;
		
	/**
	 * 
	 */
	createMiss(): void;
		
	/**
	 * 
	 * @param baseRow 
	 * @param value 
	 */
	createDigits(baseRow : number, value : any): void;
		
	/**
	 * 
	 * @return  
	 */
	createChildSprite(): Sprite_Damage.prototype.CreateChildSpriteRet;
		
	/**
	 * 
	 */
	update(): void;
		
	/**
	 * 
	 * @param sprite 
	 */
	updateChild(sprite : Sprite_Damage.prototype.UpdateChild0): void;
		
	/**
	 * 
	 */
	updateFlash(): void;
		
	/**
	 * 
	 */
	updateOpacity(): void;
		
	/**
	 * 
	 * @return  
	 */
	isPlaying(): boolean;
}

/**
 * -----------------------------------------------------------------------------
 * Sprite_StateIcon
 * 
 * The sprite for displaying state icons.
 */
declare interface Sprite_StateIcon {
		
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
	loadBitmap(): void;
		
	/**
	 * 
	 * @param battler 
	 */
	setup(battler : any): void;
		
	/**
	 * 
	 */
	update(): void;
		
	/**
	 * 
	 * @return  
	 */
	animationWait(): number;
		
	/**
	 * 
	 */
	updateIcon(): void;
		
	/**
	 * 
	 */
	updateFrame(): void;
		
	/**
	 * 
	 */
	_iconWidth : number;
		
	/**
	 * 
	 */
	_iconHeight : number;
}

/**
 * -----------------------------------------------------------------------------
 * Sprite_StateOverlay
 * 
 * The sprite for displaying an overlay image for a state.
 */
declare interface Sprite_StateOverlay {
		
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
	loadBitmap(): void;
		
	/**
	 * 
	 * @param battler 
	 */
	setup(battler : any): void;
		
	/**
	 * 
	 */
	update(): void;
		
	/**
	 * 
	 * @return  
	 */
	animationWait(): number;
		
	/**
	 * 
	 */
	updatePattern(): void;
		
	/**
	 * 
	 */
	updateFrame(): void;
}

/**
 * -----------------------------------------------------------------------------
 * Sprite_Weapon
 * 
 * The sprite for displaying a weapon image for attacking.
 */
declare interface Sprite_Weapon {
		
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
	 * @param weaponImageId 
	 */
	setup(weaponImageId : any): void;
		
	/**
	 * 
	 */
	update(): void;
		
	/**
	 * 
	 * @return  
	 */
	animationWait(): number;
		
	/**
	 * 
	 */
	updatePattern(): void;
		
	/**
	 * 
	 */
	loadBitmap(): void;
		
	/**
	 * 
	 */
	updateFrame(): void;
		
	/**
	 * 
	 * @return  
	 */
	isPlaying(): boolean;
}

/**
 * -----------------------------------------------------------------------------
 * Sprite_Balloon
 * 
 * The sprite for displaying a balloon icon.
 */
declare interface Sprite_Balloon {
		
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
	loadBitmap(): void;
		
	/**
	 * 
	 * @param balloonId 
	 */
	setup(balloonId : any): void;
		
	/**
	 * 
	 */
	update(): void;
		
	/**
	 * 
	 */
	updateFrame(): void;
		
	/**
	 * 
	 * @return  
	 */
	speed(): number;
		
	/**
	 * 
	 * @return  
	 */
	waitTime(): number;
		
	/**
	 * 
	 * @return  
	 */
	frameIndex(): number;
		
	/**
	 * 
	 * @return  
	 */
	isPlaying(): boolean;
}

/**
 * -----------------------------------------------------------------------------
 * Sprite_Picture
 * 
 * The sprite for displaying a picture.
 */
declare interface Sprite_Picture {
		
	/**
	 * 
	 * @return  
	 */
	new (): Sprite_Picture;
}


/**
 * -----------------------------------------------------------------------------
 * Sprite_Timer
 * 
 * The sprite for displaying the timer.
 */
declare interface Sprite_Timer {
		
	/**
	 * 
	 * @return  
	 */
	new (): Sprite_Timer;
}


/**
 * -----------------------------------------------------------------------------
 * Sprite_Destination
 * 
 * The sprite for displaying the destination place of the touch input.
 */
declare interface Sprite_Destination {
		
	/**
	 * 
	 * @return  
	 */
	new (): Sprite_Destination;
}


/**
 * -----------------------------------------------------------------------------
 * Spriteset_Base
 * 
 * The superclass of Spriteset_Map and Spriteset_Battle.
 */
declare interface Spriteset_Base {
		
	/**
	 * 
	 * @return  
	 */
	new (): Spriteset_Base;
}


/**
 * -----------------------------------------------------------------------------
 * Spriteset_Map
 * 
 * The set of sprites on the map screen.
 */
declare interface Spriteset_Map {
		
	/**
	 * 
	 * @return  
	 */
	new (): Spriteset_Map;
}


/**
 * -----------------------------------------------------------------------------
 * Spriteset_Battle
 * 
 * The set of sprites on the battle screen.
 */
declare interface Spriteset_Battle {
		
	/**
	 * 
	 * @return  
	 */
	new (): Spriteset_Battle;
}

