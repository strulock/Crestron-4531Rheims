namespace Satellite_Radio;
        // class declarations
         class InitializeSiriusXM;
         class SiriusXM;
         class SiriusXMMenu;
         class MenuList;
     class InitializeSiriusXM 
    {
        // class delegates
        delegate FUNCTION DelegateFnString ( SIMPLSHARPSTRING myString );

        // class events

        // class functions
        FUNCTION InitializeSiriusXMMain ( STRING name );
        FUNCTION AddTransport ();
        FUNCTION myTransport_Sendback ( STRING stream );
        FUNCTION RegisterPlayerObject ( SiriusXM MediaPlayer );
        FUNCTION RegisterMenuObject ( SiriusXMMenu MediaMenu , SiriusXM MediaPlayer );
        FUNCTION MessageIn ( STRING pkt );
        FUNCTION UnregisterClients ();
        STRING_FUNCTION ToString ();
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();

        // class variables
        INTEGER __class_id__;

        // class properties
        DelegateProperty DelegateFnString MessageOut;
    };

     class SiriusXM 
    {
        // class delegates
        delegate FUNCTION DelegateFnNoParams ( );
        delegate FUNCTION DelegateFnString ( SIMPLSHARPSTRING myString );
        delegate FUNCTION DelegateFnInt ( SIGNED_LONG_INTEGER myInt );
        delegate FUNCTION DelegateFn2Strings ( SIMPLSHARPSTRING myString1 , SIMPLSHARPSTRING myString2 );

        // class events

        // class functions
        FUNCTION initialize ( SIGNED_LONG_INTEGER numActions , SIGNED_LONG_INTEGER numProperties );
        FUNCTION AssignStatusMsgButtons ( STRING text1 , STRING text2 , STRING text3 , STRING text4 , STRING text5 );
        FUNCTION SetTextLine ( SIGNED_LONG_INTEGER index , STRING text , SIGNED_LONG_INTEGER addtoDictionary );
        FUNCTION TriggerBusyEvent ( SIGNED_LONG_INTEGER state , SIGNED_LONG_INTEGER timeoutval );
        FUNCTION TriggerStateChangedEvent ();
        FUNCTION TriggerStatusMsgEvent ( STRING text , SIGNED_LONG_INTEGER timeoutSec , STRING userInputRequired , SIGNED_LONG_INTEGER show );
        FUNCTION TriggerMediaReady ( SIGNED_LONG_INTEGER ready );
        STRING_FUNCTION ToString ();
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();

        // class variables
        STRING SiriusXMMenuName[];
        STRING Name[];

        // class properties
        DelegateProperty DelegateFnNoParams NextPresetSplus;
        DelegateProperty DelegateFnNoParams PreviousPresetSplus;
        DelegateProperty DelegateFnNoParams TuneUpSplus;
        DelegateProperty DelegateFnNoParams TuneDownSplus;
        DelegateProperty DelegateFnNoParams CategoryUpSplus;
        DelegateProperty DelegateFnNoParams CategoryDownSplus;
        DelegateProperty DelegateFnNoParams PINEntryCanceledSplus;
        DelegateProperty DelegateFnString UserInputSplus;
        DelegateProperty DelegateFnInt SavePresetSplus;
        DelegateProperty DelegateFnInt RecallPresetSplus;
        DelegateProperty DelegateFnInt ClearPresetSplus;
        DelegateProperty DelegateFnInt CheckPinSplus;
        DelegateProperty DelegateFn2Strings DirectTuneSplus;
        SIGNED_LONG_INTEGER SavePresetPending;
        SIGNED_LONG_INTEGER PresetToSave;
        SIGNED_LONG_INTEGER PinEntryPending;
        SIGNED_LONG_INTEGER Version;
        SIGNED_LONG_INTEGER Instance;
        STRING Language[];
        STRING ActionsSupported[][];
        STRING ActionsAvailable[][];
        STRING PropertiesSupported[][];
        SIGNED_LONG_INTEGER RewindSpeed;
        SIGNED_LONG_INTEGER FfwdSpeed;
        STRING ProviderName[];
        STRING PlayerState[];
        SIGNED_LONG_INTEGER PlayerIcon;
        STRING PlayerName[];
        STRING StreamState[];
        STRING MediaType[];
        STRING Title[];
        STRING Artist[];
        STRING Album[];
        STRING Genre[];
        STRING Composer[];
        STRING AlbumArtUrl[];
        STRING StationName[];
        SIGNED_LONG_INTEGER ElapsedSec;
        SIGNED_LONG_INTEGER TrackSec;
        SIGNED_LONG_INTEGER TrackNum;
        SIGNED_LONG_INTEGER TrackCnt;
        STRING NextTitle[];
        SIGNED_LONG_INTEGER MaxPresets;
        STRING PresetNames[][];
        SIGNED_LONG_INTEGER ShuffleState;
        SIGNED_LONG_INTEGER RepeatState;
        STRING TextLines[][];
        STRING Band[][];
        SIGNED_LONG_INTEGER Rating;
    };

     class SiriusXMMenu 
    {
        // class delegates
        delegate FUNCTION DelegateFnInt ( SIGNED_LONG_INTEGER myInt );
        delegate FUNCTION DelegateFn2Int ( SIGNED_LONG_INTEGER myInt1 , SIGNED_LONG_INTEGER myInt2 );
        delegate FUNCTION DelegateFnNoParams ( );

        // class events

        // class functions
        FUNCTION initialize ( SIGNED_LONG_INTEGER numItems );
        FUNCTION SetMenuListItem ( SIGNED_LONG_INTEGER index , STRING L1 , STRING L2 , STRING URL );
        STRING_FUNCTION GetMenuListItem ( SIGNED_LONG_INTEGER index );
        FUNCTION TriggerStateChangedEvent ();
        FUNCTION TriggerBusyEvent ( SIGNED_LONG_INTEGER state , SIGNED_LONG_INTEGER timeoutval );
        FUNCTION TriggerUpdateEvent ( SIGNED_LONG_INTEGER item , SIGNED_LONG_INTEGER count );
        FUNCTION TriggerClearEvent ();
        STRING_FUNCTION ToString ();
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();

        // class variables
        STRING Name[];

        // class properties
        DelegateProperty DelegateFnInt MenuLineSelectedSplus;
        DelegateProperty DelegateFnInt ItemHeldSplus;
        DelegateProperty DelegateFn2Int GetDataSplus;
        DelegateProperty DelegateFnNoParams BackSelectedSplus;
        DelegateProperty DelegateFnNoParams ResetSplus;
        SIGNED_LONG_INTEGER Version;
        STRING Language[];
        SIGNED_LONG_INTEGER Instance;
        STRING Title[];
        SIGNED_LONG_INTEGER ItemCnt;
        STRING FindDesired[];
        STRING FindSupported[][];
        SIGNED_LONG_INTEGER Level;
        STRING Sorted[];
        SIGNED_LONG_INTEGER MaxReqItems;
        STRING ListSpecificFunctions[][];
    };

