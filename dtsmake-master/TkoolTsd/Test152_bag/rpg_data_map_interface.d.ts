
/** コモンイベント */
declare interface IDataCommonEvent {
    id?: number;
    list?: IDataList[];
    name: string;
    switchId: number;
    trigger: number;
    meta?: any;
}

declare interface IVehicle {
    bgm?: IDataSound;
    characterIndex?: number;
    characterName?: string;
    startMapId?: number;
    startX?: number;
    startY?: number;
}

declare interface IDataSystem {
    airship?: IVehicle;
    armorTypes?: string[];
    attackMotions?: {
        type?: number;
        weaponImageId?: number;
    }[];
    battleBgm?: IDataSound;
    battleback1Name?: string;
    battleback2Name?: string;
    battlerHue?: number;
    battlerName?: string;
    boat?: IVehicle;
    currencyUnit?: string;
    defeatMe?: IDataSound;
    editMapId?: number;
    elements?: string[];
    equipTypes?: string[];
    gameTitle?: string;
    gameoverMe?: IDataSound;
    locale?: string;
    magicSkills?: number[];
    menuCommands?: boolean[];
    optDisplayTp?: boolean;
    optDrawTitle?: boolean;
    optExtraExp?: boolean;
    optFloorDeath?: boolean;
    optFollowers?: boolean;
    optSideView?: boolean;
    optSlipDeath?: boolean;
    optTransparent?: boolean;
    partyMembers?: number[];
    ship?: IVehicle;
    skillTypes?: string[];
    sounds?: IDataSound[];
    startMapId?: number;
    startX?: number;
    startY?: number;
    switches?: string[];
    terms?: {
        basic?: string[];
        commands: string[];
        params: string[];
        messages: {
            possession: string;
            expTotal: string;
            expNext: string;
            saveMessage: string;
            loadMessage: string;
            file?: string;
            partyName?: string;
            emerge?: string;
            preemptive?: string;
            surprise?: string;
            escapeStart?: string;
            escapeFailure?: string;
            victory?: string;
            defeat?: string;
            obtainExp?: string;
            obtainGold?: string;
            obtainItem?: string;
            levelUp?: string;
            obtainSkill?: string;
            useItem?: string;
            criticalToEnemy?: string;
            criticalToActor?: string;
            actorDamage?: string;
            actorRecovery?: string;
            actorGain?: string;
            actorLoss?: string;
            actorDrain?: string;
            actorNoDamage?: string;
            actorNoHit?: string;
            enemyDamage?: string;
            enemyRecovery?: string;
            enemyGain?: string;
            enemyLoss?: string;
            enemyDrain?: string;
            enemyNoDamage?: string;
            enemyNoHit?: string;
            evasion?: string;
            magicEvasion?: string;
            magicReflection?: string;
            counterAttack?: string;
            substitute?: string;
            buffAdd?: string;
            debuffAdd?: string;
            buffRemove?: string;
            actionFailure?: string;
            bgmVolume?: string;
            bgsVolume?: string;
            meVolume?: string;
            seVolume?: string;
            alwaysDash?: string;
            commandRemember?: string;
        };
    };
    testBattlers?: {
        actorId?: number;
        equips?: number[];
        level?: number;
    }[];
    testTroopId?: number;
    title1Name?: string;
    title2Name?: string;
    titleBgm?: IDataSound;
    variables?: string[];
    versionId?: number;
    victoryMe?: IDataSound;
    weaponTypes?: string;
    windowTone?: number[];
    meta?: any;
}

declare interface IDataMapInfo {
    id?: number;
    expanded?: boolean;
    name?: string;
    order?: number;
    parentId?: number;
    scrollX?: number;
    scrollY?: number;
    meta?: any;
}

declare interface IDataEncounterList {
    regionSet?: number[];
    troopId?: number;
    weight?: number;
}

declare interface IDataMapEventPage {
    conditions?: {
        actorId?: number;
        actorValid?: boolean;
        itemId?: number;
        itemValid?: boolean;
        selfSwitchCh?: string;
        selfSwitchValid: boolean;
        switch1Id?: number;
        switch1Valid?: boolean;
        switch2Id?: number;
        switch2Valid?: boolean;
        variableId?: number;
        variableValid?: boolean;
        variableValue?: number;
    };
    directionFix?: boolean;
    image?: {
        tileId?: number;
        characterName?: string;
        direction?: number;
        pattern?: number;
        characterIndex?: number;
    }
    list?: IDataMapEventPageList[];
    moveFrequency?: number;
    moveRoute?: {
        list?: {
            code?: number;
            parameters?: number[];
        }[];
        repeat?: boolean;
        skippable?: boolean;
        wait?: boolean;
    };
    moveSpeed?: number;
    moveType?: number;
    priorityType?: number;
    stepAnime?: boolean;
    through?: boolean;
    trigger?: number;
    walkAnime?: boolean;
}

declare interface IDataMapEvent {
    id?: number;
    name?: string;
    note?: string;
    pages?: IDataMapEventPage[];
}

declare interface IDataMap {
    autoplayBgm?: boolean;
    autoplayBgs?: boolean;
    battleback1Name?: string;
    battleback2Name?: string;
    bgm?: IDataSound;
    bgs?: IDataSound;
    disableDashing?: boolean;
    displayName?: string;
    encounterList?: IDataEncounterList[];
    encounterStep?: number;
    height?: number;
    note?: string;
    parallaxLoopX?: boolean;
    parallaxLoopY?: boolean;
    parallaxName?: string;
    parallaxShow?: boolean;
    parallaxSx?: number;
    parallaxSy?: number;
    scrollType?: number;
    specifyBattleback?: boolean;
    tilesetId?: number;
    width?: number;
    data?: number[];
    events?: IDataMapEvent[];
    meta?: any;
}